using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class County:IEntity
    {
        public int CountyId { get; set; }
        public string CountyName { get; set; }
    }
}
