using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Desciription.Length >= 2 && car.DailyPrice>0)
            {
                _carDal.Add(car);

            }

            else
            {
                Console.WriteLine("Araba ile ilgili açıklama en az iki karakter içermelidir.!\n"+
                                  "Arabanın günlük fiyatı sıfırdan büyük olmalıdır.!");
            }
            
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarByCarId(int id)
        {
            return _carDal.GetAll(c=>c.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId ==id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId == id);
        }

        public void Update(Car car)
        {
            if (car.Desciription.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);

            }

            else
            {
                Console.WriteLine("Araba ile ilgili açıklama en az iki karakter içermelidir.!\n" +
                                  "Arabanın günlük fiyatı sıfırdan büyük olmalıdır.!");
            }
        }
    }
}
