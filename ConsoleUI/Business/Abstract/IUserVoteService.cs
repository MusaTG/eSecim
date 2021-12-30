using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IUserVoteService
    {
        IDataResult<List<UserVote>> GetAll();
        IDataResult<UserVote >Get(string TC);
        IResult Add(UserVote userVote);

    }
}
