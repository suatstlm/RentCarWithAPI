using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _useDal;
        public UserManager(IUserDal userDal)
        {
            _useDal = userDal;
        }
        public IResult Add(User user)
        {
            _useDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _useDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<User> Get(int id)
        {
            return new SuccessDataResult<User>(_useDal.Get(u => u.UserId == id));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_useDal.GetAll());
        }

        public IResult Update(User user)
        {
            _useDal.Update(user);
            return new SuccessResult();
        }
    }
}
