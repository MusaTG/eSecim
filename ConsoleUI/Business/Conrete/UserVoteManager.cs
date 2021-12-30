using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Conrete
{
    public class UserVoteManager : IUserVoteService
    {
        IUserVoteDal _userVoteDal;
        public UserVoteManager(IUserVoteDal userVoteDal)
        {
            _userVoteDal = userVoteDal;
        }

        public IResult Add(UserVote userVote)
        {
            IResult result = BusinessRules.Run(CheckIfMayoralInUserVote(userVote.UserId));
            if (result != null)
                return result;
            _userVoteDal.Add(userVote);
            return new SuccesResult(Messages.UserVoteAdded);
        }

        public IDataResult<UserVote> Get(string TC)
        {
            return new SuccessDataResult<UserVote>(_userVoteDal.Get(uv => uv.UserId == TC));
        }

        public IDataResult<List<UserVote>> GetAll()
        {
            return new SuccessDataResult<List<UserVote>>(_userVoteDal.GetAll());
        }

        private IResult CheckIfMayoralInUserVote(string TC)
        {
            var result = _userVoteDal.GetAll(uv => uv.UserId == TC).Any();
            if (result)
                return new ErrorResult(Messages.MayoralInUserVote);
            return new SuccesResult();
        }
    }
}
