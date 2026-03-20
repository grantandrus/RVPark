using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RVPark.Models;

namespace RVPark.Pages.Profile
{
    public class VehicleModel : PageModel
    {
        [BindProperty]
        public VehicleViewModel Vehicle { get; set; }

        public void OnGet()
        {
            // TODO: Load current vehicle info from DB if exists
            Vehicle = new VehicleViewModel
            {
                Make = "Ford",
                Model = "F-150",
                Year = 2020,
                LicensePlate = "ABC-123",
                Color = "Blue"
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // TODO: Save vehicle info to database
            TempData["Success"] = "Vehicle information saved successfully!";
            return RedirectToPage("./Index");
        }
    }
}