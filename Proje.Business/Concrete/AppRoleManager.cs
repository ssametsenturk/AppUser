using Proje.Business.Interfaces;
using Proje.DataAccess.Interfaces;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Concrete
{
	public class AppRoleManager : GenericManager<AppRole>, IAppRoleService
	{
		public AppRoleManager(IGenericDal<AppRole> genericDal) : base(genericDal)
		{

		}
	}
}
