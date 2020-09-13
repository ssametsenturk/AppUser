using Microsoft.EntityFrameworkCore;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
	public class AppUserMap : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AppUser> builder)
		{
			builder.HasKey(I => I.Id);
			builder.Property(I => I.Id).UseSqlServerIdentityColumn();

			builder.Property(I => I.UserName).HasMaxLength(100).IsRequired();
			builder.HasIndex(I => I.UserName).IsUnique();

			builder.Property(I => I.Password).HasMaxLength(100).IsRequired();
			builder.Property(I => I.FullName).HasMaxLength(150);

			builder.HasMany(I => I.AppUserRoles).WithOne(I => I.AppUser).HasForeignKey(I => I.AppUserId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.HasMany(I => I.DFiles).WithOne(I => I.AppUser).HasForeignKey(I => I.AppUserId);
		}
	}
}
