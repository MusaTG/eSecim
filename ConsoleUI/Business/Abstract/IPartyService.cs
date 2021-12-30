using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPartyService
    {
        IDataResult<List<Party>> GetAll();
        IDataResult<Party> Get(int id);
    }
}
