using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IUserOperationClaimInfoDal : IEntityRepository<UserOperationClaim>
    {
        List<UserClaimForUserInfoDto> GetUserDetails();
    }
}
