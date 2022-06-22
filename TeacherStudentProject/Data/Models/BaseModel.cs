

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
    public abstract class BaseModel : IBaseKey, IAuditInf
    {
        
       
        public DateTime CreatedAt { get; set; }
        public int Id { get ; set ; }
    }
}
