﻿using FinalTeacherStudentProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Services.Interfaces
{
   public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllAsync();
        Task<Student> GetByIdAsync(string id);
        Task AddAsync(Student student);
        Student Update(int id, Student newStudent);
        void Delete(int id);
    }
}
