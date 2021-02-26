using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentArchiveDal : EfEntityRepositoryBase<RentArchive, MyDatabaseContext>, IRentArchiveDal
    {
        public List<RentArchiveDetailDto> GetArchiveDetails()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from ra in context.RentArchives
                             join c in context.Cars
                             on ra.CarId equals c.CarId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join cstmr in context.Customers
                             on ra.CustomerId equals cstmr.Id
                             join u in context.Users
                             on cstmr.UserId equals u.Id

                             select new RentArchiveDetailDto
                             {
                                 Id = ra.Id,
                                 CarId = c.CarId,
                                 CarBrand = b.BrandName,
                                 CarModel = c.Desciription,
                                 CustomerCumpany = cstmr.CompanyName,
                                 CustomerName = u.FirstName,
                                 CustomerLastName = u.LastName,
                                 CustomerEmail = u.Email,
                                 DailyRentPrice = c.DailyPrice,
                                 RentDate = ra.RentDate,
                                 ReturnDate = ra.ReturnDate,
                                 CarName = c.CarName


                             };
                return result.ToList();
            }

        }
    }
}
