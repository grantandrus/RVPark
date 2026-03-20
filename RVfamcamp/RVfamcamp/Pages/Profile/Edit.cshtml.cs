using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RVPark.Models;

namespace RVPark.Pages.Profile
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public ProfileViewModel Profile { get; set; }

        public void OnGet()
        {
            // TODO: Load user info from DB
            Profile = new ProfileViewModel
            {
                Id = 1,
                FirstName = "Mock",
                LastName = "User",
                Email = "Test@me.com",
                Phone = "999-999-9999",
                DateOfBirth = new DateTime(1990, 1, 1)
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Save updates to database
            TempData["Success"] = "Profile updated successfully!";

            return RedirectToPage("./Index");
        }
    }
}