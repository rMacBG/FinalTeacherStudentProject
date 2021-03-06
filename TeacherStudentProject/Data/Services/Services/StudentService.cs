using TeacherStudentProject.Data.ApplicationContext;
using TeacherStudentProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherStudentProject.Services.Interfaces;

namespace TeacherStudentProject.Data.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolLibDbContext _context;
        public StudentService(SchoolLibDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var result = await _context.Students.FirstOrDefaultAsync(n => n.Id == id);
            _context.Students.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            var  result = await _context.Students.ToListAsync();
            return result;
        }

        public async Task<Student> GetByIdAsync(Guid id)
        {
            var result = await _context.Students.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Student> UpdateAsync(Guid id, Student student)
        {
           
            _context.Update(student);
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
