using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MISAPI.Filters;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [misAuthor("B254")]
    public class HomeController : ControllerBase
    {
        [AllowAnonymous]
        [misAuthor("reportid")]
        [HttpGet]
        public IActionResult checkfunc()
        {
            string str = "Function is running";
            return Ok(new { result = str});
        }
    }
}

