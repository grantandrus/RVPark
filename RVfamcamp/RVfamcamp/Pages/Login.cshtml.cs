using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace RVfamcamp.Pages
{
    public class LoginModel : PageModel
    {
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (Request.Form["email_input"] == "temp@gmail" && Request.Form["password_input"] == "temp")
            {
                HttpContext.Session.SetString("User", "Exists");
                return RedirectToPage("/Index");
            }

            return Page();
        }

    }
}
