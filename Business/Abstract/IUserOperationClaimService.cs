using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IResult AddUserClaim(UserOperationClaim userOperationClaim);
        IResult DeleteUserClaim(UserOperationClaim userOperationClaim);
        IResult UpdateUserClaim(UserOperationClaim userOperationClaim);
        IDataResult<List<UserOperationClaim>> GetAllClaims();
        IDataResult<List<UserClaimForUserInfoDto>> GetUserClaimByUserId(int userId);
        IDataResult<UserOperationClaim> GetById(int id);
        
    }
}
