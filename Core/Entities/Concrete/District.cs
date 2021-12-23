using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class District:IEntity
    {
        public int Id { get; set; }
        public string DistrictName { get; set; }
        public int CountyId { get; set; }
    }
}
