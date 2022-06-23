using TeacherStudentProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Services.Interfaces
{
   public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(Guid id);
        Task AddAsync(Student student);
        Task<Student> UpdateAsync(Guid id, Student newStudent);
        Task DeleteAsync(Guid id);
        
    }
}
