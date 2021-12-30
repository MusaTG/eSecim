using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class MayoralDetailDto:IDto
    {
        public string Name { get; set; }
        public string PartyName { get; set; }
        public string CountyName { get; set; }
        public int VoteNumber { get; set; }
    }
}
