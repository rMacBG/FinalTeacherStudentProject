using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.Models
{
    public class Register
    {
        [Display(Name= "Email Adress")]
        [Required(ErrorMessage = "No email given")]
        public string EmailAdress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name ="Password Confirmation is requried!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Passwords do not match!")]

        public string ConfirmPassword { get; set; }
    }
}
