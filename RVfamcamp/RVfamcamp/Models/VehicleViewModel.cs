using System;
using System.ComponentModel.DataAnnotations;

namespace RVPark.Models
{
    public class VehicleViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Make")]
        public string Make { get; set; }

        [Display(Name = "Model")]
        public string Model { get; set; }

        [Display(Name = "Year")]
        [Range(1900, 2100)]
        public int? Year { get; set; }

        [Display(Name = "License Plate")]
        public string LicensePlate { get; set; }

        [Display(Name = "Color")]
        public string Color { get; set; }

        // Optional: Add fields for Vehicle Type, Registration Expiration, etc.
    }
}