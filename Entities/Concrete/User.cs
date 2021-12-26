using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class User:IEntity
    {
        public string TCNumber { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}
