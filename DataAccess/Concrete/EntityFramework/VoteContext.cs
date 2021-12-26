using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class VoteContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Vote;Trusted_Connection=true");
        }
        public DbSet<County> County { get; set; }
        //public DbSet<User> User { get; set; }
        public DbSet<District> District { get; set; }
    }
}
