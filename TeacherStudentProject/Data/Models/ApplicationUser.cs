using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Email Adress")]
        public string EmailAdress { get; set; }
    }
}
