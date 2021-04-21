using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Entities.Concrete.Dto;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }


        
        public IDataResult<List<OperationClaim>> GetClaims(User user)
        {
            return new SuccessDataResult<List<OperationClaim>>(_userDal.GetClaims(user));
        }

        
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.NewUserAdded);
        }

        
        public IDataResult<User>GetByMail(string email)
        {
            return new SuccessDataResult<User>( _userDal.Get(u => u.Email == email));
        }

        
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<UserClaimForUserInfoDto>> GetUserDetail()
        {
            return new SuccessDataResult<List<UserClaimForUserInfoDto>>(_userDal.UserDetail());
        }

        public IDataResult<List<UserOperationClaimDto>> GetClaimByUserId(int userId)
        {
            return new SuccessDataResult<List<UserOperationClaimDto>>(_userDal.GetClaimByUserId(x => x.UserId == userId));
        }

        public IDataResult<User> GetUserByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(x => x.Id == userId));
        }

        public IResult Update(User user)
        {
            var resultUser = GetUserByUserId(user.Id);

            if (user.FirstName != null && user.LastName != null)
            {
                user.Email = resultUser.Data.Email;
                user.PasswordHash = resultUser.Data.PasswordHash;
                user.PasswordSalt = resultUser.Data.PasswordSalt;
                user.Status = resultUser.Data.Status;

                _userDal.Update(user);
                return new SuccessResult(Messages.UpdatedOk);
            }
            
            else if (user.Email != null)
            {
                user.FirstName = resultUser.Data.FirstName;
                user.LastName = resultUser.Data.LastName;
                user.PasswordHash = resultUser.Data.PasswordHash;
                user.PasswordSalt = resultUser.Data.PasswordSalt;
                user.Status = resultUser.Data.Status;

                _userDal.Update(user);
                return new SuccessResult(Messages.UpdatedOk);
            }

            else
            {
                return new ErrorResult(Messages.UpdatedNo);
            }

        }
    }
}
