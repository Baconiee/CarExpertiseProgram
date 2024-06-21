using CarExpertise.Data;
using CarExpertise.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext
builder.Services.AddDbContext<ApplicationDbContext>(options => {
    var config = builder.Configuration;
    var connectionString = config.GetConnectionString("CarExpertiseDbConnection");
    options.UseSqlServer(connectionString);
});

// Add Identity
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Configure application cookie
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Identity/Account/Login";
    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
});

// Add claims transformation to include CompanyName
builder.Services.AddScoped<IClaimsTransformation, CompanyNameClaimsTransformation>();

builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizePage("/"); // Tüm sayfalar için yetkilendirme ekliyoruz
});

var app = builder.Build();

// Create a scope to get services
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    try
    {
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

        await CreateAdminUser(userManager, roleManager);
    }
    catch (Exception ex)
    {
        // Handle errors
        Console.WriteLine("Error creating admin user: " + ex.Message);
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customer}/{action=Main}/{id?}");

app.MapRazorPages();

app.Run();

static async Task CreateAdminUser(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
{
    string adminEmail = "admin@gmail.com";
    string adminPassword = "BerkayGüler_3232";

    Console.WriteLine("Checking if Admin role exists...");

    if (await roleManager.RoleExistsAsync("Admin") == false)
    {
        var roleResult = await roleManager.CreateAsync(new IdentityRole("Admin"));
        if (!roleResult.Succeeded)
        {
            Console.WriteLine("Error creating admin role: " + string.Join(", ", roleResult.Errors.Select(e => e.Description)));
        }
        else
        {
            Console.WriteLine("Admin role created successfully.");
        }
    }

    var adminUser = await userManager.FindByEmailAsync(adminEmail);

    if (adminUser == null)
    {
        adminUser = new ApplicationUser
        {
            UserName = adminEmail,
            Email = adminEmail,
            EmailConfirmed = true,
            TaxNumber = "123456789",
            Office = "Main Office",
            Logo = "logo.png",
            CompanyName = "Admin Company",
            PhoneNumber = "1234567890",
            Address = "123 Admin St.",
            CompanyId = 1
        };

        var result = await userManager.CreateAsync(adminUser, adminPassword);

        if (result.Succeeded)
        {
            var roleAssignResult = await userManager.AddToRoleAsync(adminUser, "Admin");
            if (!roleAssignResult.Succeeded)
            {
                Console.WriteLine("Error assigning admin role: " + string.Join(", ", roleAssignResult.Errors.Select(e => e.Description)));
            }
            else
            {
                Console.WriteLine("Admin role assigned successfully.");
            }
        }
        else
        {
            Console.WriteLine("Error creating admin user: " + string.Join(", ", result.Errors.Select(e => e.Description)));
        }
    }
    else
    {
        Console.WriteLine("Admin user already exists.");
    }
}
