using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserDetailDto:IDto
    {
        public string TC { get; set; }
        public string CountyName { get; set; }
        public string DistrictName { get; set; }    
    }
}
