using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeacherStudentProject.Data.Models;

namespace TeacherStudentProject.Data.Models
{
    public class Teacher : BaseModel
    {
        
        [Required(ErrorMessage = "A First Name is required to be given!")]
       [StringLength(45, MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "A Surname is required to be given!")]
        [StringLength(45, MinimumLength = 3)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "A Family Name is required to be given!")]
        [StringLength(45, MinimumLength = 3)]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }
        [Required(ErrorMessage = "At least one speciality must be given!")]
        public Speciality Speciality { get; set; }
        public List<Email> Email { get; set; }

    }
}
