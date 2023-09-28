using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MISAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class checkhealthcontroller:ControllerBase
	{
		public checkhealthcontroller()
		{
		}
		[HttpGet(Name = "checkhealth")]
        [Authorize]
		public String checkhealth()
		{
			return $"System is Ok";
		}

	}
}

