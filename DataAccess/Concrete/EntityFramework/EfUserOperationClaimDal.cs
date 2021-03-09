using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim,MyDatabaseContext>,IUserOperationClaimDal
    {
                
        public List<UserClaimForUserInfoDto> GetUserDetails()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from uoc in context.UserOperationClaims
                             join us in context.Users
                             on uoc.UserId equals us.Id

                             join oc in context.OperationClaims
                             on uoc.OperationClaimId equals oc.Id

                             select new UserClaimForUserInfoDto
                             {
                                 UserId = us.Id,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 Email = us.Email,
                                 ClaimName = oc.Name
                                 

                             };
                return result.ToList();
            }
        }
    }
}
