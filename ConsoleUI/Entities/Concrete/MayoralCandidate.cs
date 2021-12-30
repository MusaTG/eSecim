using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class MayoralCandidate:IEntity
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CountyId { get; set; }
        public int PartyId { get; set; }
        public int VoteNumber { get; set; }
    }
}
