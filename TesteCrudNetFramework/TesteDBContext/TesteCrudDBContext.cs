using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using TesteCrudNetFramework.Models;

namespace TesteCrudNetFramework.TesteDBContext
{
    public class TesteCrudDBContext : DbContext
    {
        public TesteCrudDBContext() : base("TesteDb")
        {

        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manobrista>().HasKey(k => k.Cpf);

        }

        public DbSet<Manobrista> Manobristas { get; set; }
    }
}