using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProfileImagesService
    {
        IResult Add(IFormFile file, ProfileImage profileImage);
        IResult Delete(ProfileImage profileImages);
        IResult Update(IFormFile file, ProfileImage profileImages);
        IDataResult<ProfileImage> GetById(int id);
        IDataResult<List<ProfileImage>> GetAll();
        IDataResult<List<ProfileImage>>GetProfileImagesByUserId(int userId);
    }
}
