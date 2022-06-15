using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
  public class Grade : BaseModel
    {
        public new int Id { get; set; }
        public Grade Grades { get; set; }
    }
}
