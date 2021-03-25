using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByCarId(int id);
        IDataResult<List<CarDetailDto>> GetCarsByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsByCarId(int carId);
        IDataResult<List<CarDetailDto>> GetCarDetailsFilter(int brandId,int colorId);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<List<ImagePathDto>> GetImageByCarId(int carId);
        
        
        


        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        
    }
}
