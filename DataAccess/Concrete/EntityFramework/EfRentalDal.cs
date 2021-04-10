using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                
                
                    var result = from r in filter == null? context.Rentals : context.Rentals.Where(filter)
                                 join c in context.Cars
                                 on r.CarId equals c.CarId
                                 join b in context.Brands
                                 on c.BrandId equals b.BrandId
                                 join co in context.Colors
                                 on c.ColorId equals co.ColorId
                                 join cstmr in context.Customers
                                 on r.CustomerId equals cstmr.Id
                                 join u in context.Users
                                 on cstmr.UserId equals u.Id
                                 
                                 select new RentalDetailDto
                                 {
                                     Id = r.Id,
                                     CarId = c.CarId,
                                     CarBrand = b.BrandName,
                                     CarModel = c.Description,
                                     CustomerCompany = cstmr.CompanyName,
                                     CustomerName = u.FirstName,
                                     CustomerLastName = u.LastName,
                                     CustomerEmail = u.Email,
                                     DailyRentPrice = c.DailyPrice,
                                     RentDate = r.RentDate,
                                     ReturnDate = r.ReturnDate,
                                     CarName = c.CarName,
                                     CustomerId=cstmr.Id

                                     


                                 };
                    return result.ToList();

                  

               
            }
        }
    }
}
