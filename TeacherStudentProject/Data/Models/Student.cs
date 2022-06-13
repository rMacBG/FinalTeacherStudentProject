using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
  public  class Student : BaseModel
    {
        
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FamilyName { get; set; }
        public string Speciality { get; set; }
        public string Grade { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Email> StudentEmails { get; set; }
    }
}
