using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
  public class Grade : BaseModel
    {
        public string Grades { get; set; }

        public List<Grade> Grading { get; set; }


    }
}
