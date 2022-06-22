using System;
using System.Collections.Generic;

namespace FinalTeacherStudentProject.Data.Models
{
    public class Teacher : BaseModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FamilyName { get; set; }
        public ICollection<Speciality> Specialities { get; set; }

        public DateTime BirthDate { get; set; }
       

    }
}
