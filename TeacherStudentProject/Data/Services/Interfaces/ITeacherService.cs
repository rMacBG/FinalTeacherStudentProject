using TeacherStudentProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace TeacherStudentProject.Data.Services.Interfaces
{
   public interface ITeacherService
    {
        
        Task<Teacher> GetByIdAsync(Guid id);
        Task AddAsync(Teacher teacher);
        Task<Teacher> UpdateAsync(Guid id, Teacher newTeacher);
        Task DeleteAsync(Guid id);

        Task<IEnumerable<Teacher>> GetAllAsync();
        Task<IEnumerable<Teacher>> GetAllAsync(params Expression<Func<Teacher, object>>[] includeProperties);
    }
}
