using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using RVfamcamp.Models;

public class CreateModel : PageModel
{
    [BindProperty]
    public Reservation Reservation { get; set; }

    public void OnGet()
    {
        Reservation = new Reservation();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        // TODO: Save to database

        return RedirectToPage("Index");
    }
}