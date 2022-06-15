using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
   public class Speciality : BaseModel
    {
      
        public Speciality SpecialityType { get; set; }
    }
}
