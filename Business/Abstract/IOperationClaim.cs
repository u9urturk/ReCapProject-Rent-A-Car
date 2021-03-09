using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOperationClaimService
    {
        IResult AddClaim(OperationClaim operationClaim);
        IResult DeleteClaim(OperationClaim operationClaim);
        IDataResult<List<OperationClaim>> GetAllClaims();
        IDataResult<OperationClaim> GetById(int claimId);

    }
}
