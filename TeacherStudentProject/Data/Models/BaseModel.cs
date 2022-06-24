

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherStudentProject.Models.Interfaces;

namespace TeacherStudentProject.Data.Models
{
    public class BaseModel : IAuditInf
    {
        public BaseModel()
        {
            this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
    }
}
