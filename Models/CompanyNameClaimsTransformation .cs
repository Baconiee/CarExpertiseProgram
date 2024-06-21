using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using CarExpertise.Models;

public class CompanyNameClaimsTransformation : IClaimsTransformation
{
    private readonly UserManager<ApplicationUser> _userManager;

    public CompanyNameClaimsTransformation(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        if (principal.Identity.IsAuthenticated)
        {
            var userId = _userManager.GetUserId(principal);
            var user = await _userManager.FindByIdAsync(userId);

            if (user != null)
            {
                var identity = (ClaimsIdentity)principal.Identity;

                // Check if the claim already exists, if not add it
                if (!identity.HasClaim(c => c.Type == "CompanyName"))
                {
                    identity.AddClaim(new Claim("CompanyName", user.CompanyName ?? string.Empty));
                }
            }
        }

        return principal;
    }
}
