using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserFindexPointService
    {
       
        IDataResult<UserFindeksPoint> GetFindeksPointByUserId(int customerId);
        IResult Add(UserFindeksPoint userFindeksPoint);
        IResult Delete(UserFindeksPoint userFindeksPoint);
        IResult Update(UserFindeksPoint userFindeksPoint);
    }
}
