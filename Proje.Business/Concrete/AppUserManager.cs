using Proje.Business.Interfaces;
using Proje.DataAccess.Interfaces;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Concrete
{
	public class AppUserManager : GenericManager<AppUser>, IAppUserService
	{
		//brdaki genericDal base ile GenericManagerin constructoruna yerlesecek
		public AppUserManager(IGenericDal<AppUser> genericDal) : base(genericDal)
		{

		}
	}
}
