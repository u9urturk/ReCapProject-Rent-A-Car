using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OperationClaimManager : IOperationClaimService
    {
        IOperationClaimDal _operationDal;
        public OperationClaimManager(IOperationClaimDal operationClaim)
        {
            _operationDal = operationClaim;
        }
        
        public IResult AddClaim(OperationClaim operationClaim)
        {
            _operationDal.Add(operationClaim);
            return new SuccessResult(Messages.ClaimAdded);

        }

        public IResult DeleteClaim(OperationClaim operationClaim)
        {
            _operationDal.Delete(operationClaim);
            return new SuccessResult(Messages.DeletedClaim);
        }

        public IDataResult<List<OperationClaim>> GetAllClaims()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationDal.GetAll());
        }

        public IDataResult<OperationClaim> GetById(int claimId)
        {
            return new SuccessDataResult<OperationClaim>(_operationDal.Get(b => b.Id == claimId));
        }
    }
}
