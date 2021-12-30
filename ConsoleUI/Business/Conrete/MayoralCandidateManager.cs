using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingCornerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Result;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Conrete
{
    public class MayoralCandidateManager : IMayoralCandidateService
    {
        IMayoralCandidateDal _mayoralCandidateDal;
        IUserDal _userDal;

        public MayoralCandidateManager(IMayoralCandidateDal mayoralCandidateDal)
        {
            _mayoralCandidateDal = mayoralCandidateDal;
            _userDal = new EfUserDal();
        }

        [ValidationAspect(typeof(MayoralCandidateValidator))]
        public IResult Add(MayoralCandidate mayoralCandidate)
        {
            IResult result = BusinessRules.Run(CheckIfMayoralInUser(mayoralCandidate.UserId), CheckIfMayoralTCExits(mayoralCandidate.UserId));

            if (result != null)
                return result;

            _mayoralCandidateDal.Add(mayoralCandidate);
            return new SuccesResult(Messages.MayoralAdded);
        }

        public IDataResult<List<MayoralCandidate>> GetAll()
        {
            return new SuccessDataResult<List<MayoralCandidate>>(_mayoralCandidateDal.GetAll());
        }

        public IDataResult<MayoralCandidate> GetById(int mayoralId)
        {
            return new SuccessDataResult<MayoralCandidate>(_mayoralCandidateDal.Get(m => m.Id == mayoralId));
        }

        public IDataResult<List<MayoralDetailDto>> GetMayoralDetails()
        {
            if (_mayoralCandidateDal.GetMayoralDetails().Count == 0)
                return new ErrorDataResult<List<MayoralDetailDto>>(Messages.MayoralNone);
            return new SuccessDataResult<List<MayoralDetailDto>>(_mayoralCandidateDal.GetMayoralDetails(), Messages.MayoralListed);
        }

        [ValidationAspect(typeof(MayoralCandidate))]
        public IResult Update(MayoralCandidate mayoralCandidate)
        {
            _mayoralCandidateDal.Update(mayoralCandidate);
            return new SuccesResult(Messages.VoteAdded);
        }

        private IResult CheckIfMayoralTCExits(string TC)
        {
            var result = _mayoralCandidateDal.GetAll(mc => mc.UserId == TC).Any();
            if (result)
                return new ErrorResult(Messages.MayoralCountOfError);
            return new SuccesResult();
        }

        private IResult CheckIfMayoralInUser(string TC)
        {
            var result = _userDal.GetAll(u => u.TCNumber == TC).Any();
            if (result)
                return new ErrorResult(Messages.MayoralTCInvalid);
            return new SuccesResult();
        }
    }
}
