using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDistrictDal : IDistrictDal
    {
        public District Get(Expression<Func<District, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<District> GetAll(Expression<Func<District, bool>> filter = null)
        {
            using(VoteContext context=new VoteContext())
            {
                return filter == null
                    ? context.Set<District>().ToList()
                    : context.Set<District>().Where(filter).ToList();
            }
        }
    }
}
