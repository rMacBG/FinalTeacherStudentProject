using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherStudentProject.Data.Models;

namespace TeacherStudentProject.Data.Models
{
  public  class Student : BaseModel
    {

       

        [Required(ErrorMessage ="A First Name is required to be given!")]
        [StringLength(45, MinimumLength = 3)]
        [Display(Name= "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A Surname is required to be given!")]
        [StringLength(45, MinimumLength = 3)]
        public string Surname { get; set; }

        [Required(ErrorMessage = "A Family Name is required to be given!")]
        [StringLength(45, MinimumLength = 3)]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "A Speciality must be chosen!")]
        public Speciality Speciality { get; set; }
        [Required(ErrorMessage ="A grade must be given!")]
        public Grade Grade { get; set; }
        [Required(ErrorMessage = "Birth Date must be given to the student!")]
        [Display(Name ="Birth Date")]
        public DateTime BirthDate { get; set; }

        public List<Email> Email{ get; set; }
    }
}
