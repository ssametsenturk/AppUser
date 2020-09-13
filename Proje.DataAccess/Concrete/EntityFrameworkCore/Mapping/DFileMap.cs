using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
	public class DFileMap : IEntityTypeConfiguration<DFile>
	{

		public void Configure(EntityTypeBuilder<DFile> builder)
		{
			builder.HasKey(I => I.Id);
			builder.Property(I => I.Id).UseSqlServerIdentityColumn();

			builder.Property(I => I.Name).HasMaxLength(150).IsRequired();
		}
	}
}
