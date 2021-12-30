using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICountyService
    {
        IDataResult<List<County>> GetAll();
        IDataResult<County> Get(int id);
    }
}
