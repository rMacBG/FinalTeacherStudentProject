using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
   public class Speciality : BaseModel
    {
        public int Id { get; set; }
        public Speciality SpecialityType { get; set; }
    }
}
