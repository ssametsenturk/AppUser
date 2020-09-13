using Proje.Business.Interfaces;
using Proje.DataAccess.Interfaces;
using Proje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Business.Concrete
{
	public class DFileManager : GenericManager<DFile>, IDFileService
	{
		public DFileManager(IGenericDal<DFile> genericDal) : base(genericDal)
		{
				
		}
	}
}
