using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Annotations
{
    internal class Employee
    {
        [Required(ErrorMessage = "Employee {0} is required")]
        [StringLength(100, MinimumLength = 2, ErrorMessage =("Name should contain at least two letters and maximum 100"))]
        [DataType(DataType.Text)]
        public string name { get; set; }

        [Range(18,99, ErrorMessage = ("Age should be between 18 and 99"))]
        public int age { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string phoneNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string email { get; set; }
    }
}
