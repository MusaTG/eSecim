using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace Entities.Concrete
{
    public class UserVote : IEntity 
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ElectedMayorId { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}
