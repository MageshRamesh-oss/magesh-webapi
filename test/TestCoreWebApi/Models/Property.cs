using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWebApi.Models
{
    public class Property
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
    public class SecondClass
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class RequestSample
    {
        public List<SecondClass> secondClasses { get; set; }
    }

    
}
