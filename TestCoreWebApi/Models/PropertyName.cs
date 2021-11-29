using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWebApi.Models
{
    public class PropertyName
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int id { get; set; }
        [EmailAddress]
        public string email { get; set; }
    }
}
