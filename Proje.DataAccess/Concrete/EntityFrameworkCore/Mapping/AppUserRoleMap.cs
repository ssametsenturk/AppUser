using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
	public class AppUserRoleMap : IEntityTypeConfiguration<AppUserRole>
	{
		public void Configure(EntityTypeBuilder<AppUserRole> builder)
		{
			builder.HasKey(I => I.Id);
			builder.Property(I => I.Id).UseSqlServerIdentityColumn();

			//bir appuserin sadece 1 rolu olmalidir bunun tekrarini onlemek icin
			//artik bu ikili dataseti unique oldu tekrarli verinin onune gecmis olduk
			builder.HasIndex(I => new { I.AppUserId, I.AppRoleId }).IsUnique();
		}
	}
}
