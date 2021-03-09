using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, MyDatabaseContext>, ICustomerDal
    {
        public List<CustomerInfoDto> GetCustumerInfo()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from cstm in context.Customers
                             join us in context.Users
                             on cstm.UserId equals us.Id

                             select new CustomerInfoDto
                             {
                                 CustomerId = cstm.Id,
                                 CustomerName = us.FirstName,
                                 CustomerLastName = us.LastName,
                                 Email = us.Email

                             };
                return result.ToList();
            }
        }
    }
}
