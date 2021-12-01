using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleWebApi.Models
{
    public class AdditionalProperty
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int id { get; set; }
        [EmailAddress]
        public string email { get; set; }
    }
}