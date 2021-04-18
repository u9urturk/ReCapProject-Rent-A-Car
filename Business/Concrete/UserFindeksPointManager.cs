using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrete;
using Core.Utilities;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;


namespace Business.Concrete
{
    public class UserFindeksPointManager : IUserFindexPointService
    {
        IUserFindeksPointDal _UserFindeksPointDal;
        

        public UserFindeksPointManager(IUserFindeksPointDal userFindeksPointDal)
        {
            _UserFindeksPointDal = userFindeksPointDal;
        }
        public IResult Add(UserFindeksPoint userFindeksPoint)
        {
            userFindeksPoint.FindeksPoint = 100;
            _UserFindeksPointDal.Add(userFindeksPoint);
            return new SuccessResult(Messages.FindeksPointCreated);
        }

        public IResult Delete(UserFindeksPoint userFindeksPoint)
        {
            _UserFindeksPointDal.Delete(userFindeksPoint);
            return new SuccessResult(Messages.FindeksPointDeleted);
        }

        public IDataResult<UserFindeksPoint> GetFindeksPointByUserId(int userId)
        {
            return new SuccessDataResult<UserFindeksPoint>(_UserFindeksPointDal.Get(u => u.CustomerId == userId));
        }

        public IResult Update(UserFindeksPoint userFindeksPoint)
        {
            IResult result = BusinessRules.Run(UpdateFindeksPoint(userFindeksPoint.CustomerId));
            if (result != null)
            {
                return result;
            }

            var result2 = _UserFindeksPointDal.Get(u=>u.CustomerId == userFindeksPoint.CustomerId);
            userFindeksPoint.FindeksPoint = result2.FindeksPoint + 300;
            _UserFindeksPointDal.Update(userFindeksPoint);
            return new SuccessResult(Messages.FindeksPointUpdated);
        }

        // Business Rules

        private IResult UpdateFindeksPoint(int customerId)
        {
            var result = _UserFindeksPointDal.Get(u => u.CustomerId == customerId);
            if (result.FindeksPoint >= 1900)
            {
                return new ErrorResult(Messages.MaxFindeksPointExceeded);
            }
            return new SuccessResult();
        }
    }
}
