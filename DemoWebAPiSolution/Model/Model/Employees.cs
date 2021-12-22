using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    class Employees
    {
        [Key]
        public int EmpId { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string EmpName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string EmpAddress { get; set; }
        [Phone]
        public int? EmpPhone { get; set; }
        [EmailAddress]
        public string? EmpEmailID { get; set; }
        [Required]
        public double? EmpSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EmpDob { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public string EmpDateOfJoining { get; set; }
        [RegularExpression("^([A-Za-z]){5}([0-9]){4}([A-Za-z]){1}$")]
        public string EmpPan { get; set; }
    }
}
