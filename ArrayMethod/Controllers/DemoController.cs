using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayMethod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        public DemoController()
        {

        }

        public List<int> GetArray(string str)
        {
            return str.Split(" ").Select(i => Convert.ToInt32(i)).ToList();
        }

        [HttpGet("SumOfArray/{str}")]
        public IActionResult SumOfArray(string str)
        {
            List<int> arr = GetArray(str);
            return Ok("Sum of Array "+arr.Sum());
        }
    }
}
