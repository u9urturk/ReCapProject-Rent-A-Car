using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public Car()
        {
            Images = new List<CarImage>();
        }
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Desciription { get; set; }

        public List<CarImage> Images { get; set; }
    }

    
}
