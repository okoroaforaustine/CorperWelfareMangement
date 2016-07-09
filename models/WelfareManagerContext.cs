using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations.Schema;

namespace CorpersWelfareManager.Models
{
    public class WelfareManagerContext:IdentityDbContext<IdentityUser>
    {
        public WelfareManagerContext():base("WelfareManagerContext")
        {
            

        }


        public DbSet<Allocation> Allocation { get; set; }
        public DbSet<Corper> Corper { get; set; }
        public DbSet<MonthlyDues> MonthlyDues { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            
            modelBuilder.Entity<MonthlyDues>().HasRequired(x => x.Corper).WithMany(x => x.MonthlyDues);

            



        }
        
    }
}