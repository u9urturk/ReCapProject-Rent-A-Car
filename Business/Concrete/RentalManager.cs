using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAllRentals()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.GetAllDetails);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetDetails(),Messages.RentalList);
        }

        public IResult RentCar(Rental rental)
        {
            var result = _rentalDal.GetAll().FindAll(r=>r.ReturnDate==null);

            if (result.Count > 0 && result.SingleOrDefault(r => r.CarId == rental.CarId)==default(Rental))
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            else
            {
                return new ErrorResult(Messages.NullYes);
            }
           
            
        }

        public IResult ReturnedCar(Rental rental)
        {
            var result = _rentalDal.GetAll().FindAll(r=>r.ReturnDate == null);

            if (result.Count > 0 && result.SingleOrDefault(r=>r.CarId == rental.CarId) != default(Rental))
            {
                _rentalDal.Update(rental);
                return new SuccessResult(Messages.RentalUpdated);
            }
            else
            {
                return new ErrorResult(Messages.notRented);
            }
           
        }
    }
}
