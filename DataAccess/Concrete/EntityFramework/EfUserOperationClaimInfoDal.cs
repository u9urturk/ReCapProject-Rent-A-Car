using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.DTOs;
using System.Linq;
using System.Collections.Generic;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimInfoDal : EfEntityRepositoryBase<UserOperationClaim, MyDatabaseContext>, IUserOperationClaimInfoDal
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
