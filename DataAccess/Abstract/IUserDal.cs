using Core.DataAccess;
using Core.Entities.Concrete;
using Core.Entities.Concrete.Dto;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal: IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
        List<UserClaimForUserInfoDto> GetAllUserDetail();

        List<UserOperationClaimDto> GetClaimByUserId(Expression<Func<UserOperationClaim, bool>> filter = null);
    }
}
