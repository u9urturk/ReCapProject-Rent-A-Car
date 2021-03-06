﻿using Core.Entities.Concrete;
using Core.Entities.Concrete.Dto;
using Core.Utilities.Results;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IResult Add(User user);
        IResult Update(User user);
        IDataResult<User> GetByMail(string email);
        IDataResult<User> GetUserByUserId(int userId);
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserClaimForUserInfoDto>> GetAllUserDetail();

        IDataResult<List<UserOperationClaimDto>> GetClaimByUserId(int userId);
    }
}
