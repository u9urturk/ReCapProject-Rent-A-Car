using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    [SecuredOperation("Admin")]
    public class RentArchiveManager : IRentArchiveService
    {
        IRentArchiveDal _rentArchiveDal;

        public RentArchiveManager(IRentArchiveDal rentArchiveDal)
        {
            _rentArchiveDal = rentArchiveDal;
        }

        public IResult AddArchive(RentArchive rentArchive)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<RentArchiveDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentArchiveDetailDto>>(_rentArchiveDal.GetArchiveDetails(),Messages.RentArchiveList);
        }
    }
}
