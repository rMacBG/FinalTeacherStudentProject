using TeacherStudentProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Data.Services.Interfaces
{
   public interface ITeacherService
    {
        Task<IEnumerable<Teacher>> GetAllAsync();
        Task<Teacher> GetByIdAsync(Guid id);
        Task AddAsync(Teacher teacher);
        Task<Teacher> UpdateAsync(Guid id, Teacher newTeacher);
        Task DeleteAsync(Guid id);
    }
}
