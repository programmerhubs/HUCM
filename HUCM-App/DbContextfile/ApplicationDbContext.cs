using System;
using HUCM_App.Models;
using Microsoft.EntityFrameworkCore;

namespace HUCM_App.DbContextfile
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
		{
		}
		public DbSet<User> Usertbl { get; set; }
        public DbSet<Employee> Employeestbl { get; set; }
        public DbSet<EmployeeJourney> EmployeeJourneystbl { get; set; }
        public DbSet<EmpPwd> EmpPwdsTbl { get; set; }
        public DbSet<EmpRole> EmpRolesTbl { get; set; }
        public DbSet<Department> Departmentstbl { get; set; }
        public DbSet<Resign> ResignsTbl { get; set; }
        public DbSet<Skill> SkillsTbl { get; set; }
        public DbSet<ResignReason> ResignReasonsTbl { get; set; }
        public DbSet<Project> ProjectsTbl { get; set; }
        public DbSet<TableHandler> TableHandlersTbl { get; set; }
        public DbSet<TableHandlerHistory> TableHandlerHistoriesTbl { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpPwd>().HasNoKey();
            modelBuilder.Entity<EmployeeJourney>().HasNoKey();
            modelBuilder.Entity<TableHandlerHistory>().HasNoKey();
           

            base.OnModelCreating(modelBuilder);
        }

    }
}