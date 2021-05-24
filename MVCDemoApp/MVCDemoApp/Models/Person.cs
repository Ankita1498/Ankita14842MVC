using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Models
{
    public class Person
    {
       

        [Required(ErrorMessage = "Name is compulsory field")]
        [StringLength(10, ErrorMessage = "Maximum Name length is 10 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is compulsory field")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone is compulsory field")]
        public int? Phone { get; set; }

        [Required(ErrorMessage = "Select any one, it is a compulsory field")]
        public string WillAttend { get; set; }
    }
}
