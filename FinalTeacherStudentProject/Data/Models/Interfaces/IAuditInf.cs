using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Models.Interfaces
{
   public interface IAuditInf
    {
        public DateTime CreatedAt { get; set; }
        public DateTime EditedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
