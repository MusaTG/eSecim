using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class VoteContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P0EG6QC;Database=Vote;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasNoKey();
        }
        public DbSet<County> County { get; set; }
        public DbSet<MayoralCandidate> MayoralCandidate { get; set; }
        public DbSet<Party> Party { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserVote> UserVotes { get; set; }
    }
}
