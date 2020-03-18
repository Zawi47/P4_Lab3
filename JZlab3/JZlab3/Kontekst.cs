using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace JZlab3
{
    class Kontekst :DbContext
    {
        public DbSet<Lab> Labs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"");
        }
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Lab>().Property(x => x.Nazwa).HasMaxLength(255).HasColumnName("NazwaFluent");
        }
        */
    }
}
