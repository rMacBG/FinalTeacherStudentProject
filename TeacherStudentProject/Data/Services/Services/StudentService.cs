using FinalTeacherStudentProject.Data.ApplicationContext;
using FinalTeacherStudentProject.Data.Models;
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
        public void Create(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll(string FirstName)
        {
            var result = _context.Students.ToList();
            return result;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(int id, Student newStudent)
        {
            throw new NotImplementedException();
        }
    }
}
