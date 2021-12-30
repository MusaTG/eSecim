using Business.Abstract;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Conrete
{
    public class PartyManager : IPartyService
    {
        IPartyDal _partyDal;

        public PartyManager(IPartyDal partyDal)
        {
            _partyDal = partyDal;
        }

        public IDataResult<Party> Get(int id)
        {
            return new SuccessDataResult<Party>(_partyDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Party>> GetAll()
        {
            return new SuccessDataResult<List<Party>>(_partyDal.GetAll());
        }
    }
}
