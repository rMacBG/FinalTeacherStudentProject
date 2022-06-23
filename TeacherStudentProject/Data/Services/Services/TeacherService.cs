using TeacherStudentProject.Data.ApplicationContext;
using TeacherStudentProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherStudentProject.Data.Services.Interfaces;

namespace TeacherStudentProject.Data.Services.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly SchoolLibDbContext _context;

        public TeacherService(SchoolLibDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Teacher teacher)
        {
            await _context.Teachers.AddAsync(teacher);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var result = await _context.Teachers.FirstOrDefaultAsync(n => n.Id == id);
            _context.Teachers.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Teacher>> GetAllAsync()
        {
            var result = await _context.Teachers.ToListAsync();
            return result;
        }

        public async Task<Teacher> GetByIdAsync(Guid id)
        {
            var result = await _context.Teachers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Teacher> UpdateAsync(Guid id, Teacher newTeacher)
        {
            _context.Update(newTeacher);
            await _context.SaveChangesAsync();
            return newTeacher;
        }
    }
}
