using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;

namespace DataAccess.EntityFramework.Context
{
    public class VoteContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SurveySelection;Trusted_Connection=true");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<County> Counties { get; set; }
    }
}
