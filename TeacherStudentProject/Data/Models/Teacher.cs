using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalTeacherStudentProject.Data.Models
{
    public class Teacher : BaseModel
    {
       [Required]
        public string FirstName { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string FamilyName { get; set; }
        [Required]
        public ICollection<Speciality> Specialities { get; set; }
        public ICollection<Email> TeacherEmails { get; set; }

    }
}
