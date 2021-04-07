using Business.Abstract;
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
using Core.Aspects.Autofac.Cache;
using Core.Aspects.Autofac.Performance;

namespace Business.Concrete
{
    
     
    public class RentalManager : IRentalService
    { 
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult AddTransactionalTest(Rental rental)
        {
            _rentalDal.Add(rental);
            _rentalDal.UpdateAndMove(rental);
            return new SuccessResult(Messages.UnexpectedError);
        }

        // NOT : PerformanceAspectler tüm metotlara tanımlanmıştır-- İlgili kod AspectInterceptorSelector Class'ı içerisindedir.
        
        [CacheAspect(duration: 10)]
        public IDataResult<List<Rental>> GetAllRentals()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),Messages.GetAllDetails);
        }

        public IDataResult<Rental> GetRantalDetailByRentalId(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r => r.Id == id));
        }

        
        [CacheAspect]
        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetDetails(),Messages.RentalList);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetDetails(r => r.CustomerId == customerId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetailsByCarId(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetDetails(r => r.CarId == carId));
        }

        [ValidationAspect(typeof(RentalValidator))]
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult RentCar(Rental rental)
        {
            var result = _rentalDal.GetDetails(r => r.CarId == rental.CarId);
            var control = result.FindAll(g => g.RentDate == rental.RentDate);
            var control2 = result.FindAll(g => g.ReturnDate == rental.ReturnDate);

            if (control.Count < 0 && control2.Count < 0)
            {
                
                
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);

            }
            else
            {
                return new ErrorResult(Messages.NullYes);
            }

        }
        
        [CacheRemoveAspect("IRentalService.Get")]
        public IResult ReturnedCar(Rental rental)
        {
            var result = _rentalDal.GetAll().FindAll(r=>r.ReturnDate == null);
            

            if (result.Count >= 0 && result.SingleOrDefault(r => r.CarId == rental.CarId) != default(Rental))
            {
                
                _rentalDal.UpdateAndMove(rental);
                // UpdateAndMove metodu diğer Update metodundan farklı olarak Rentals tablosunda yapılan güncellemenin bir kopyasını
                //EfEntityRepositoryBase class'ı içerisinde yazdığım SQL komutu ile RentArchives tablosunda oluşturuyor
                //Sonrasında bir sonraki kod bloğu çalışıyor ve Rentals tablosunda ReturnDate'i null olmayan değerleri bulup siliyor.
                //Sonuç olarak Rentals tablomuzda sadece kira süreci devam eden araçların listesi tutuluyor.Kira süreci tamamlanmış kira bilgileri ise 
                //Farklı bir tabloda Arşiv adı altında tutuluyor.
                

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
      
    }
}
