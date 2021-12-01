using SampleWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SampleWebApi.Controllers
{
    public class TestController : ApiController
    {
        List<AdditionalProperty> properties = new List<AdditionalProperty>()
        {
            new AdditionalProperty()
            {
                id=0,
                Name="Magesh",
                email="magesh@gmail.com"
            },
            new AdditionalProperty()
            {
                id=0,
                Name="Venkat",
                email="Venkat@gmail.com"
            },
            new AdditionalProperty()
            {
                id=0,
                Name="Thiru",
                email="Thiru@gmail.com"
            },
            new AdditionalProperty()
            {
                id=4,
                Name="Ramesh",
                email="Ramesh@gmail.com"
            }

        };
        [HttpGet]
        [Route("{GetName}")]
        public IHttpActionResult GetMethod(string GetName)
        {
            var b1 = properties.Where(x => x.Name == GetName);
            if(b1.Any())
            return Ok(new Property { Status = Helper.StatusSuccess, Message = Helper.MessageSuccess, Data =b1});

            return NotFound();
        }


        [HttpPost]
        public IHttpActionResult PostMethod([FromBody]RequestSample requestSample)
        {

            return Ok(new Property {Status=Helper.StatusSuccess,Message=Helper.MessageSuccess,Data= requestSample.secondClasses});
        }
    }
}
