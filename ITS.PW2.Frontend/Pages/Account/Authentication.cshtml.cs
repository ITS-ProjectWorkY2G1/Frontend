using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace testBlazorServer.Pages
{
    public class AuthenticationModel : PageModel
    {
        public ActionResult OnGet()
        {
            var Action = RouteData.Values["Action"];
            
            if (Action!.ToString() == "Login")
            {
                return Challenge(new AuthenticationProperties { RedirectUri = "/" }, OpenIdConnectDefaults.AuthenticationScheme);
            }
            else if(Action.ToString() == "Logout")
            {
                return SignOut(CookieAuthenticationDefaults.AuthenticationScheme, OpenIdConnectDefaults.AuthenticationScheme);
            }
            return Redirect("/");
        }
    }
}
