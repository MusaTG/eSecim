using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IMayoralCandidateDal:IEntityRepository<MayoralCandidate>
    {
        void Add(MayoralCandidate mayorCandidate);
        void Update(MayoralCandidate mayorCandidate);
        List<MayoralDetailDto> GetMayoralDetails();
    }
}
