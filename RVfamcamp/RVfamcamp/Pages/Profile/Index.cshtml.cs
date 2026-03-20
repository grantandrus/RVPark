using Microsoft.AspNetCore.Mvc.RazorPages;
using RVPark.Models;
using System;

namespace RVPark.Pages.Profile
{
    public class IndexModel : PageModel
    {
        public ProfileViewModel Profile { get; set; }

        public void OnGet()
        {
            // TODO: Replace with actual database retrieval
            Profile = new ProfileViewModel
            {
                Id = 1,
                FirstName = "Mock",
                LastName = "User",
                Email = "test@me.com",
                Phone = "(999) 999-9999",
                DateOfBirth = new DateTime(1990, 1, 1),
                CreatedAt = DateTime.Now.AddYears(-2)
            };
        }
    }
}