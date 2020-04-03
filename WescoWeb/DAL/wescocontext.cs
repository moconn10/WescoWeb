using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WescoWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WescoWeb.DAL
{
    public class wescocontext : DbContext
    {
        public wescocontext() : base("wescocontext")
        {

        }
        public DbSet<schedule> schedules { get; set; }
        public DbSet<wesco> wescos { get; set; }
        public DbSet<employee> employees { get; set; }
        public DbSet<donut> donuts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
