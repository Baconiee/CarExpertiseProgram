using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using CarExpertise.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;



[Authorize(Roles = "Admin")]
public class AdminController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;

    public AdminController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> ManageUsers()
    {
        var users = _userManager.Users.ToList();
        var userList = new List<UserViewModel>();

        int id = 1;
        foreach (var user in users)
        {
            userList.Add(new UserViewModel
            {
                Id = id++,
                Email = user.Email,
                Password = "****", // Güvenlik sebebiyle þifreleri göstermekten kaçýnýn
                UserId = user.Id,
                TaxNumber = user.TaxNumber,
                Office = user.Office,
                Logo = user.Logo,
                CompanyName = user.CompanyName,
                PhoneNumber = user.PhoneNumber,
                Address = user.Address,
                CompanyId = user.CompanyId
            });
        }

        return View(userList);
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult AddUser()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> AddUser(AddUserViewModel model)
    {
        if (ModelState.IsValid)
        {
            // CompanyName'e göre mevcut CompanyId'yi al
            var companyIds = await _userManager.Users
                .Where(u => u.CompanyName == model.CompanyName)
                .Select(u => u.CompanyId)
                .ToListAsync();

            int companyId = companyIds.DefaultIfEmpty(0).Max();

            if (companyId == 0)
            {
                // Mevcut en büyük CompanyId'yi al ve 1 ekle
                var maxCompanyIdList = await _userManager.Users
                    .Select(u => u.CompanyId)
                    .ToListAsync();

                int maxCompanyId = maxCompanyIdList.DefaultIfEmpty(0).Max();

                companyId = maxCompanyId + 1;
            }

            var user = new ApplicationUser
            {
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true,
                TaxNumber = model.TaxNumber,
                Office = model.Office,
                CompanyName = model.CompanyName,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
                CompanyId = companyId
            };

            if (model.Logo != null)
            {
                var fileName = Path.GetFileName(model.Logo.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/logos", fileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await model.Logo.CopyToAsync(stream);
                }
                user.Logo = "/logos/" + fileName; // Veritabanýnda saklanacak dosya yolu
            }

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                return RedirectToAction("ManageUsers");
            }
            else
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteUser(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("ManageUsers");
            }
            else
            {
                // Hata durumunu yönet
                ModelState.AddModelError(string.Empty, "Kullanýcý silinemedi: " + string.Join(", ", result.Errors.Select(e => e.Description)));
            }
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Kullanýcý bulunamadý.");
        }

        // Kullanýcý silinemediðinde ayný sayfayý tekrar göster
        return RedirectToAction("ManageUsers");
    }
    [HttpGet]
    public IActionResult GetUserDetailsByCompanyName(string companyName)
    {
        var user = _userManager.Users.FirstOrDefault(u => u.CompanyName == companyName);
        if (user == null)
        {
            return NotFound();
        }

        var userDetails = new
        {
            user.TaxNumber,
            user.Office,
            user.CompanyName,
            user.PhoneNumber,
            user.Address
        };

        return Json(userDetails);
    }                       
}

public class UserViewModel
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string TaxNumber { get; set; }
    public string Office { get; set; }
    public string Logo { get; set; }
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string UserId { get; set; }
    public int CompanyId { get; set; }
}

public class AddUserViewModel
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public string TaxNumber { get; set; }
    public string Office { get; set; }
    public IFormFile Logo { get; set; } // Logo dosyasýný ekledik
    public string CompanyName { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
}