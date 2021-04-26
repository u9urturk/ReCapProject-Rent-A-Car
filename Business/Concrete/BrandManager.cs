using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        

        [SecuredOperation("Admin")]
        public IResult Add(Brand brand)
        {
            
           _brandDal.Add(brand);
            return new  SuccessResult(Messages.Added);
        }

        [SecuredOperation("Admin")]
        public IResult Delete(Brand brand)
        {
            
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.Deleted);
        }

        
        public IDataResult<List<Brand>> GetAll()
        {
            
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        [SecuredOperation("Admin")]
        public IDataResult< Brand >GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b=>b.BrandId == brandId));
        }

        [SecuredOperation("Admin")]
        public IResult Update(Brand brand)
        {
           
            _brandDal.Update(brand);
            return new SuccessResult(Messages.Updated);
        }

      
    }
}
