using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IUserOperationClaimInfoDal : IEntityRepository<UserOperationClaim>
    {
        List<UserClaimForUserInfoDto> GetUserClaimByUserId(Expression<Func<UserOperationClaim, bool>> filter = null);
    }
}
