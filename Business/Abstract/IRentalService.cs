using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult RentCar(Rental rental);
        IResult ReturnedCar(Rental rental);
        IDataResult<List<Rental>> GetAllRentals();
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult AddTransactionalTest(Rental rental);

    }
}
