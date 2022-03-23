using ArrayImplementation.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayImplementation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayController : ControllerBase
    {
        private IArrayRepo _arrayRepo;
        public ArrayController(IArrayRepo arrayRepo)
        {
            _arrayRepo = arrayRepo;
        }

        [HttpPost("AddElements")]
        public IActionResult AddElements(List<int> item)
        {
            return Ok(_arrayRepo.AddElements(item));
        }

        [HttpGet("SumOfArray")]
        public RedirectResult ArraySum()
        {
            string temp = "/SumOfArray/" + _arrayRepo.ToString();
            return new RedirectResult(url: temp);
        }

        
    }
}
