using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conrete
{
    public class CountyManager : ICountyService
    {
        ICountyDal _countyDal;

        public CountyManager(ICountyDal countyDal)
        {
            _countyDal = countyDal;
        }

        public IDataResult<County> Get(int id)
        {
            return new SuccessDataResult<County>(_countyDal.Get(c => c.Id == id));
        }

        public IDataResult<List<County>> GetAll()
        {
            return new SuccessDataResult<List<County>>(_countyDal.GetAll());
        }
    }
}
