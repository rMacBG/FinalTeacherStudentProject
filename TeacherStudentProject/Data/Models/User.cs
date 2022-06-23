using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.Models
{
    public class User : IdentityUser

    {
        [Display(Name = "Your Name")]
        public string FullName { get; set; }
        [Display(Name = "Email Adress")]
        public string EmailAdress { get; set; }
    }
}
