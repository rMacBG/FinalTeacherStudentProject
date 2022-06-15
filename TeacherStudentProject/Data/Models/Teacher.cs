using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalTeacherStudentProject.Data.Models
{
    public class Teacher : BaseModel
    {
        
        [Required]
       [StringLength(45, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 2)]
        public string FamilyName { get; set; }
        [Required]
        public ICollection<Speciality> Specialities { get; set; }
        public ICollection<Email> TeacherEmails { get; set; }

    }
}
