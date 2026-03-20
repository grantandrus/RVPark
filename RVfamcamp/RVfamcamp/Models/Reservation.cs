using System;

namespace RVfamcamp.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public string SiteNumber { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public int GuestCount { get; set; }

        public double TotalCost { get; set; }

        public string Status { get; set; }
    }
}