using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId =1,BrandId=1,ColorId=1,ModelYear=2012,DailyPrice=225,Desciription="Sedan"},
                new Car{CarId =2,BrandId=1,ColorId=2,ModelYear=2016,DailyPrice=260,Desciription="Hatchback"},
                new Car{CarId =3,BrandId=2,ColorId=3,ModelYear=2018,DailyPrice=280,Desciription="Station Wagon"},
                new Car{CarId =4,BrandId=2,ColorId=1,ModelYear=2013,DailyPrice=250,Desciription="Cabrio"},
                new Car{CarId =5,BrandId=3,ColorId=2,ModelYear=2020,DailyPrice=320,Desciription="SUV"}

            };

            
                         

        }

        public List<Brand> brands = new List<Brand>
        {
            new Brand{BrandId = 1, BrandName = "Ford Mustang"},
            new Brand{BrandId = 2, BrandName = "Kia Rio"},
            new Brand{BrandId = 3, BrandName = "Toyota Supra"},
        };

        public List<Color> colors = new List<Color>
        {
            new Color{ColorId = 1 , ColorName = "Siyah"},
            new Color{ColorId = 2 , ColorName = "Beyaz"},
            new Color{ColorId = 3 , ColorName = "Mavi"},
            new Color{ColorId = 4 , ColorName = "Kırmızı"},
        };









        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Desciription = car.Desciription;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void UpdateAndMove(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
