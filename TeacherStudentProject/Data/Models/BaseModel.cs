using FinalTeacherStudentProject.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.Models
{
    public abstract class BaseModel : IBaseKey, IAuditInf
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
      
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
       
        
    }
}
