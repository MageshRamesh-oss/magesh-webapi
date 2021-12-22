using Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Serves
{
    public class TestService:ITestService
    {
        public string GetMethod()
        {
            return "Hello World";
        }
    }
}
