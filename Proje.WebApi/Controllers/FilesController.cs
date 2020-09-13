using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proje.Business.Interfaces;

namespace Proje.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
		private readonly IDFileService _dfileService;
		public FilesController(IDFileService dfileService)
		{
			_dfileService = dfileService;
		}
		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var dfiles = await _dfileService.GetAll();
			return Ok(dfiles);
		}
    }
}