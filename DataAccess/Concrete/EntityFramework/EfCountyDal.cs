using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCountyDal : ICountyDal
    {
        public County Get(Expression<Func<County, bool>> filter)
        {
            using (VoteContext context = new VoteContext())
            {
                return context.Set<County>().SingleOrDefault(filter);
            }
        }

        public List<County> GetAll(Expression<Func<County, bool>> filter = null)
        {
            using (VoteContext context = new VoteContext())
            {
                return filter == null
                    ? context.Set<County>().ToList()
                    : context.Set<County>().Where(filter).ToList();
            }
        }
    }
}
