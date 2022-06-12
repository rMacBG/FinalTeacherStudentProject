using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
   public class Email : BaseModel
    {
        public int Id { get; set; }
        public Email EmailType { get; set; }
        public string EmailInformatiuon { get; set; }
    }
}
