using Freelance_Platform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Freelance_Platform.Data
{
    public class AppDBContext:DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Freelancers_Talents>().HasKey(ft => new
            {
                ft.FreelancerID,
                ft.TalentID
            });
            modelBuilder.Entity<Freelancers_Talents>().HasOne(f => f.Freelancer).WithMany(ft => ft.Freelancers_Talents).HasForeignKey(f => f.FreelancerID);
            modelBuilder.Entity<Freelancers_Talents>().HasOne(t => t.Talent).WithMany(ft => ft.Freelancers_Talents).HasForeignKey(t => t.TalentID);


            modelBuilder.Entity<Projects_Talents>().HasKey(pt => new
            {
                pt.ProjectID,
                pt.TalentID
            });
            modelBuilder.Entity<Projects_Talents>().HasOne(p => p.Project).WithMany(pt => pt.Projects_Talents).HasForeignKey(p => p.ProjectID);
            modelBuilder.Entity<Projects_Talents>().HasOne(t => t.Talent).WithMany(pt => pt.Projects_Talents).HasForeignKey(t => t.TalentID);

            base.OnModelCreating(modelBuilder);
        }
 
        public DbSet<Freelancer> Freelancers { get; set; }
        public DbSet<Talent> Talents { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Freelancers_Talents> Freelancers_Talents { get; set; }
        public DbSet<Projects_Talents> Projects_Talents { get; set; }


    }
}
