﻿using Business.Abstract;
using Business.Constans;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Core.Aspects.Autofac.Validation;
using Business.ValidationRules.FluentValidation;
using Business.BusinessAspect.Autofac;

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

        [SecuredOperation("rental.add,admin")]
        [ValidationAspect(typeof(RentalValidator))]
        public IResult RentCar(Rental rental)
        {
            var result = _rentalDal.GetAll().FindAll(r=>r.ReturnDate==null);

            if (result.Count >= 0 && result.SingleOrDefault(r => r.CarId == rental.CarId)==default(Rental))
            {

                rental.RentDate = DateTime.Now;
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
            

            if (result.Count >= 0 && result.SingleOrDefault(r => r.CarId == rental.CarId) != default(Rental))
            {
                
                _rentalDal.UpdateAndMove(rental);


                var result1 = _rentalDal.GetAll().FindAll(r => r.ReturnDate != null);
                if (result1.Count>= 0 && result1.Where(r=> r.ReturnDate!=null)!=default(Rental))
                {   

                    
                        _rentalDal.Delete(rental);


                    
                    

                }
                return new SuccessResult(Messages.RentalUpdated);




            }
            else
            {
                return new ErrorResult(Messages.notRented);
            }
           
        }

        //Business Rules

       

      
    }
}
