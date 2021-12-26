using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;

        public DistrictManager(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }

        public List<District> GetAll()
        {
            return _districtDal.GetAll();
        }

        public List<District> GetAllByCounty(int id)
        {
            return _districtDal.GetAll(d => d.CountyId == id);
        }
    }
}
