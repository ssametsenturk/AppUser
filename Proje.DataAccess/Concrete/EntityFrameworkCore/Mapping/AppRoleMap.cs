using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
	public class AppRoleMap : IEntityTypeConfiguration<AppRole>
	{
		public void Configure(EntityTypeBuilder<AppRole> builder)
		{
			builder.HasKey(I => I.Id);
			builder.Property(I => I.Id).UseSqlServerIdentityColumn();

			builder.Property(I => I.Id).HasMaxLength(100).IsRequired();

			builder.HasMany(I => I.AppUserRoles).WithOne(I => I.AppRole).HasForeignKey(I => I.AppRoleId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
