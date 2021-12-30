using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserVoteDal:IEntityRepository<UserVote>
    {
        void Add(UserVote userVote);
    }
}
