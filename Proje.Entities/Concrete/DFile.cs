using Proje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Entities.Concrete
{
	public class DFile : ITable
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string FilePath { get; set; }

		public int AppUserId { get; set; }
		public AppUser AppUser { get; set; }
	}
}
