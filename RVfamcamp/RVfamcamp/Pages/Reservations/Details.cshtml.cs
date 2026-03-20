using Microsoft.AspNetCore.Mvc.RazorPages;
using RVfamcamp.Models;
using System;

public class DetailsModel : PageModel
{
    public Reservation Reservation { get; set; }

    public void OnGet(int id)
    {
        // TODO: Replace with DB lookup
        Reservation = new Reservation
        {
            Id = id,
            SiteNumber = "A12",
            CheckIn = DateTime.Today,
            CheckOut = DateTime.Today.AddDays(3),
            GuestCount = 2,
            TotalCost = 150,
            Status = "Confirmed"
        };
    }
}