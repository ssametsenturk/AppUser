using Proje.DataAccess.Interfaces;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
	public class EfAppUserRoleRepository : EfGenericRepository<AppUserRole>, IAppUserRoleDal
	{
	}
}
