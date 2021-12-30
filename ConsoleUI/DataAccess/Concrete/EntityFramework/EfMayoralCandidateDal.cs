using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfMayoralCandidateDal : EfEntityRepositoryBase<MayoralCandidate, VoteContext>,IMayoralCandidateDal
    {
        public void Add(MayoralCandidate mayorCandidate)
        {
            using (VoteContext context=new VoteContext())
            {
                var addedEntity = context.Entry(mayorCandidate);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public List<MayoralDetailDto> GetMayoralDetails()
        {
            using (VoteContext context=new VoteContext())
            {
                var result = from u in context.Users
                             join mc in context.MayoralCandidate
                             on u.TCNumber equals mc.UserId
                             join p in context.Party
                             on mc.PartyId equals p.Id
                             select new MayoralDetailDto { Name = u.FirstName + " " + u.LastName, PartyName = p.Name };
                return result.ToList();
            }
        }

        public void Update(MayoralCandidate mayorCandidate)
        {
            using (VoteContext context = new VoteContext())
            {
                var updatedEntity = context.Entry(mayorCandidate);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
