using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            

            
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
            


            
            
        }

        [SecuredOperation("Admin")]
        public IResult Delete(Car car)
        {
            
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

      

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll());
        }

        public IDataResult<Car> GetByCarId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c=>c.CarId == id));
        }



        
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
          return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails(),Messages.CarList);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsFilter(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c => c.BrandId == brandId && c.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c=>c.BrandId == brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByCarId(int carId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(c=>c.CarId == carId));
        }

        public IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>( _carDal.GetCarDetails(c=>c.ColorId == colorId));
        }

        public IDataResult<List<ImagePathDto>> GetImageByCarId(int carId)
        {
            return new SuccessDataResult<List<ImagePathDto>>(_carDal.GetImageByCarId(im=>im.CarId == carId));
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Car car)
        {
           
          
            _carDal.Add(car);
             return new SuccessResult(Messages.CarUpdated);

           
            
           
        }

      

    }
}
