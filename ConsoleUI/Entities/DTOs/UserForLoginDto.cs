using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class UserForLoginDto:IDto
    {
        public string TC { get; set; }
        public string Password { get; set; }
    }
}
