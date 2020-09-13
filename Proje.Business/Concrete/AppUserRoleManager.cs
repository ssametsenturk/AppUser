using Proje.Business.Interfaces;
using Proje.DataAccess.Interfaces;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Concrete
{
	public class AppUserRoleManager : GenericManager<AppUserRole>, IAppUserRoleService
	{
		//brdaki genericDal base ile GenericManagerin constructoruna yerlesecek
		public AppUserRoleManager(IGenericDal<AppUserRole> genericDal) : base(genericDal)
		{

		}
	}
}
