using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalTeacherStudentProject.Data.Models
{
    public class Teacher : BaseModel
    {
        
        [Required(ErrorMessage = "A First Name is required to be given!")]
       [StringLength(45, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "A Surname is required to be given!")]
        [StringLength(45, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required(ErrorMessage = "A Family Name is required to be given!")]
        [StringLength(45, MinimumLength = 2)]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }
        [Required]
        public ICollection<Speciality> Specialities { get; set; }
        public ICollection<Email> TeacherEmails { get; set; }

    }
}
