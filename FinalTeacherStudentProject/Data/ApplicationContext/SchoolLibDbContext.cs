using FinalTeacherStudentProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTeacherStudentProject.Data.ApplicationContext
{
   public class SchoolLibDbContext : DbContext
    {
        public DbSet<Student> Students  { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Grade> Grades { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-APPA48Q;Database=TeachersBook;Trusted_Connection=True");
        }
    }
}
