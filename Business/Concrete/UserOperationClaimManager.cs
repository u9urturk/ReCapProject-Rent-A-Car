using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        IUserOperationClaimInfoDal _userOperationClaimDal;
        public UserOperationClaimManager(IUserOperationClaimInfoDal userOperationClaimDal)
        {
            _userOperationClaimDal = userOperationClaimDal;
        }
        public IResult AddUserClaim(UserOperationClaim userOperationClaim)
        {
            _userOperationClaimDal.Add(userOperationClaim);
            return new SuccessResult(Messages.UserAssigned);
        }

        public IResult DeleteUserClaim(UserOperationClaim userOperationClaim)
        {
            _userOperationClaimDal.Delete(userOperationClaim);
            return new SuccessResult(Messages.OperationSuccess);
        }

        public IDataResult<List<UserOperationClaim>> GetAllClaims()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimDal.GetAll());
        }

        public IDataResult<List<UserClaimForUserInfoDto>> GetUser()
        {
            return new SuccessDataResult<List<UserClaimForUserInfoDto>>(_userOperationClaimDal.GetUserDetails());
        }

        public IResult UpdateUserClaim(UserOperationClaim userOperationClaim)
        {
            _userOperationClaimDal.Update(userOperationClaim);
            return new SuccessResult(Messages.OperationSuccess);
        }
        public IDataResult<UserOperationClaim> GetById(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaimDal.Get(b => b.UserId == id));
        }

      
    }
}
