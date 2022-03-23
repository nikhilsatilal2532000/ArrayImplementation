using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayMethods.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public DemoController()
        {

        }

        [HttpGet("SumOfArray")]
        public IActionResult SumOfArray([FromBody] List<int> _arr)
        {
            return Ok("Sum of Array"+_arr.Sum());
        }
    }
}
