using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car,bool>>filter = null)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             
                             join co in context.Colors
                             on c.ColorId equals co.ColorId

                          

                             

                            

                             select new CarDetailDto 
                             { 
                                                       CarId = c.CarId,
                                                       CarName = c.CarName, 
                                                       BrandName = b.BrandName,
                                                       ColorName = co.ColorName,
                                                       DailyPrice=c.DailyPrice,
                                                       Desciription=c.Description,
                                                       ModelYear = c.ModelYear,
                                                      
                                                       
        
                             };

                return result.ToList();
            }
        }

        public List<ImagePathDto> GetImageByCarId(Expression<Func<Car, bool>> filter = null)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join im in context.CarImages
                             on c.CarId equals im.CarId

                             select new ImagePathDto
                             {
                                 Id=im.Id,
                                 CarId = c.CarId,
                                 ImagePath = im.ImagePath
                             };
                return result.ToList();
            }
        }
    }
}
