using Core.Entities.Concrete;
using Core.Entities.Concrete.Dto;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Jwt.Abstract
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<UserOperationClaimDto> operationClaimsDto);
        
    }
}
