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

        List<PropertyName> propertyNames = new List<PropertyName>()
        {
            new PropertyName()
            {
                Name="Magesh",id=0,email="magesh@gmail.com"
            },
            new PropertyName()
            {
                Name="Thiru",id=1,email="Thiru@gmail.com"
            },
            new PropertyName()
            {
                Name="Venkat",id=2,email="Venkat@gmail.com"
            },
            new PropertyName()
            {
                Name="Ajith",id=3,email="Ajith@gmail.com"
            }

        };
        [HttpGet]
        public IActionResult GetMethod()
        {
            return Ok("Sample Output");
        }
        [HttpGet]
        [Route("{propertyName}")]
        public IActionResult GetName(string propertyName)
        {
            
            var b1=propertyNames.Where(x => x.Name == propertyName);
            if(b1.Any())
            {
                return Ok(b1);
            }
            else
            {
                return NotFound("Please Enter Correct Data");
            }
            
        }
        [HttpPost]
        [Route("{PostName}")]
        public IActionResult PostGetMethod(string PostName)
        {
            if (ModelState.IsValid)
            {
                var b1 = propertyNames.Where(x => x.email == PostName);
                if (b1.Any())
                {
                    return Ok(b1);
                }
                else
                {
                    return NotFound("No Data Found");
                }
            }
         return Ok();
        }
        [HttpPost]
        
        public IActionResult PostMethod(RequestSample property)
        {
            return Ok(new Property {Status= StatusSuccess, Message= SuccessMessage, Data= property.secondClasses });
        }

    }
}
