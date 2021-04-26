using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProfileImagesManager : IProfileImagesService
    {
        IProfileImagesDal _profileImageDal;

        public ProfileImagesManager(IProfileImagesDal profileImagesDal)
        {
            _profileImageDal = profileImagesDal;
        }

        string entity = "profile";

        public IResult Add(IFormFile file, ProfileImage profileImage)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimitExceeded(profileImage.UserId));
            if (result != null)
            {
                return result;
            }


            profileImage.ImagePath = FileHelper.Add(file,entity);
            profileImage.Date = DateTime.Now;
            _profileImageDal.Add(profileImage);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(ProfileImage profileImages)
        {
            FileHelper.Delete(profileImages.ImagePath);
            _profileImageDal.Delete(profileImages);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<List<ProfileImage>> GetAll()
        {
            return new SuccessDataResult<List<ProfileImage>>(_profileImageDal.GetAll());
        }

        public IDataResult<ProfileImage> GetById(int id)
        {
            var result = _profileImageDal.Get(i => i.Id == id);
            return new SuccessDataResult<ProfileImage>(result);
        }

        public IDataResult<List<ProfileImage>> GetProfileImagesByUserId(int userId)
        {
            return new SuccessDataResult<List<ProfileImage>>(CheckIfCarImageNull(userId));
        }

        public IResult Update(IFormFile file, ProfileImage profileImages)
        {
            profileImages.ImagePath = FileHelper.Update(_profileImageDal.Get(i => i.Id == profileImages.Id).ImagePath, file,entity);
            profileImages.Date = DateTime.Now;
            _profileImageDal.Update(profileImages);
            return new SuccessResult(Messages.UpdatedOk);
        }

        //Business Rules

        private IResult CheckIfImageLimitExceeded(int userId)
        {
            var result = _profileImageDal.GetAll(i => i.UserId == userId).Count;
            if (result >= 1)
            {
                return new ErrorResult(Messages.ProfileImageLimitExceeded);
            }
            return new SuccessResult();
        }

        private List<ProfileImage> CheckIfCarImageNull(int id)
        {
            string path = @"\wwwroot\ProfileImages\logo.jpg";
            var result = _profileImageDal.GetAll(i => i.UserId == id).Any();
            if (!result)
            {
                return new List<ProfileImage> { new ProfileImage { UserId = id, ImagePath = path, Date = DateTime.Now } };
            }
            return _profileImageDal.GetAll(i => i.UserId == id);
        }
    }
}
