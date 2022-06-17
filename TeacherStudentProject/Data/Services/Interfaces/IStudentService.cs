using FinalTeacherStudentProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Services.Interfaces
{
   public interface IStudentService
    {
        IEnumerable<Student> GetAll(string FirstName);
        Student GetById(int id);
        void Create(Student student);
        Student Update(int id, Student newStudent);
        void Delete(int id);
    }
}
