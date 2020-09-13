using Microsoft.EntityFrameworkCore;
using Proje.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Context
{
	public class ProjeContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=.;database=myDb;trusted_connection=true;");
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AppUserMap());
			modelBuilder.ApplyConfiguration(new AppRoleMap());
			modelBuilder.ApplyConfiguration(new AppUserRoleMap());
			modelBuilder.ApplyConfiguration(new DFileMap());
		}

		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }
		public DbSet<AppUserRole> AppUserRoles { get; set; }
		public DbSet<DFile> DFiles { get; set; }
	}
}
