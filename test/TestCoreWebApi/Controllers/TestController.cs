using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestCoreWebApi.Models;

namespace TestCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        const string StatusSuccess = "Sus0011";
        const string SuccessMessage = "Successfully Fetched";
        [HttpGet]
        public IActionResult GetMethod()
        {
            return Ok("Sample Output");
        }
        [HttpPost]
        public IActionResult PostMethod(RequestSample property)
        {
            return Ok(new Property {Status= StatusSuccess, Message= SuccessMessage, Data= property });
        }

    }
}
