using Core.Entities;
using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto:IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerCompany { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CustomerEmail { get; set; }
        public int CustomerId { get; set; }
        public decimal DailyRentPrice { get; set; }
        public DateTime? RentDate  { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
