using Business.Abstract;
using Business.Costance;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckCarReturnDate());
            if (result != null)
            {
                return result;
            }

            _rentalDal.Add(rental);
            return new SuccessResult();
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IDataResult<Rental> Get(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(b => b.RentalId == id));
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        public IResult CheckCarReturnDate()
        {
            var result = _rentalDal.Get(r => r.ReturnDate == null);
            if (result == null)
            {
                return new ErrorResult(Messages.CheckCarRent);
            }
            return new SuccessResult("");
        }

        public IDataResult<List<RentalDetialDto>> GetRentalDetialDto()
        {
            return new SuccessDataResult<List<RentalDetialDto>>(_rentalDal.GetRentalDetialDto());
        }
    }
}
