using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        List<District> GetAll();
        List<District> GetAllByCounty(int id);
    }
}
