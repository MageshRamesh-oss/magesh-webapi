using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    class Departments
    {
        [Key]
        public int? DeptID { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string DeptName { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string DeptManager { get; set; }
        [Required]
        public int? EmpId { get; set; }
    }
}
