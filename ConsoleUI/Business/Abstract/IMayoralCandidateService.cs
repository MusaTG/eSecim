using Core.Utilities.Result;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMayoralCandidateService
    {
        IResult Add(MayoralCandidate mayoralCandidate);
        IResult Update(MayoralCandidate mayoralCandidate);
        IDataResult<MayoralCandidate> GetById(int mayoralId);
        IDataResult<List<MayoralDetailDto>> GetMayoralDetails();
        IDataResult<List<MayoralCandidate>> GetAll();
    }
}
