using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security
{
   public class Transaction
    {
        public string UserId { get; set; }
        public int MayorId { get; set; }
        public int PartyId { get; set; }

        public override string ToString()
        {
            return UserId + ":"+ MayorId.ToString()+":"+PartyId.ToString() ;
        }
    }
}
