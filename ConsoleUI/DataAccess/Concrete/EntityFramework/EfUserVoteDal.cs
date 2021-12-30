using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserVoteDal : EfEntityRepositoryBase<UserVote, VoteContext>, IUserVoteDal
    {
        public void Add(UserVote userVote)
        {
            using (VoteContext context=new VoteContext())
            {
                var addedEntity = context.Entry(userVote);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
    }
}
