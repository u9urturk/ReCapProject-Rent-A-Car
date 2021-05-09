using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;
using System.Linq.Expressions;
using Core.Entities.Concrete.Dto;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, MyDatabaseContext>, IUserDal
    {
        public List<UserOperationClaimDto> GetClaimByUserId(Expression<Func<UserOperationClaim, bool>> filter = null)
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from u in filter == null ? context.UserOperationClaims : context.UserOperationClaims.Where(filter)
                             join o in context.OperationClaims
                             on u.OperationClaimId equals o.Id

                             select new UserOperationClaimDto
                             {
                                 UserId = u.UserId,
                                 Claim = o.Name
                             };

                return result.ToList();
            }
        }

        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MyDatabaseContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             join us in context.Users
                                on userOperationClaim.UserId equals us.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }

        public List<UserClaimForUserInfoDto> GetAllUserDetail()
        {
            using (var context = new MyDatabaseContext())
            {
                var result = from us in context.Users
                             join uoc in context.UserOperationClaims
                             on us.Id equals uoc.UserId

                             join co in context.OperationClaims
                             on uoc.OperationClaimId equals co.Id
                             
                             select new UserClaimForUserInfoDto
                             {
                                 Id=uoc.Id,
                                 UserId = us.Id,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 Email = us.Email,
                                 ClaimName = co.Name

                             };
                return result.ToList();
            }
        }
    }
}
