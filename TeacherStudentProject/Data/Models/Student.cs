using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
  public  class Student : BaseModel
    {

       

        [Required]
        [StringLength(45, MinimumLength = 2)]
        [Display(Name= "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 2)]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }
        public string Speciality { get; set; }
        public Grade Grade { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Email> StudentEmails { get; set; }
    }
}
