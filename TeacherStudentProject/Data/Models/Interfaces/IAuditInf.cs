using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherStudentProject.Models.Interfaces
{
   public interface IAuditInf
    {
        
        public DateTime CreatedAt { get; set; }
    }
}
