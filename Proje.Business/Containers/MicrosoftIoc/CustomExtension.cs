using Microsoft.Extensions.DependencyInjection;
using Proje.Business.Concrete;
using Proje.Business.Interfaces;
using Proje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Proje.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Containers.MicrosoftIoc
{
	public static class CustomExtension
	{
		public static void AddDependencies(this IServiceCollection services)
		{
			//IGenericService gordugun zaman GenericManageri ornekle
			services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
			//GenericDal gordugun zaman EfGenericRepositoryi ornekle
			services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));

			services.AddScoped<IDFileDal, EfDFileRepository>();
			services.AddScoped<IDFileService, DFileManager>();

			services.AddScoped<IAppUserDal, EfAppUserRepository>();
			services.AddScoped<IAppUserService, AppUserManager>();

			services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
			services.AddScoped<IAppRoleService, AppRoleManager>();

			services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepository>();
			services.AddScoped<IAppUserRoleService, AppUserRoleManager>();
		}
	}
}
