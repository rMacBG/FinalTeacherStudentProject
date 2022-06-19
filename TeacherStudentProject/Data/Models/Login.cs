using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please add your emial adress!")]
        [Display(Name ="Email Adress")]

        public string EmailAdress { get; set; }
    }
}
