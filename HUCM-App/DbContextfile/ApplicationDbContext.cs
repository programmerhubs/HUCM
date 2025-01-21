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
		public DbSet<User> usertbl { get; set; }
	}
}

