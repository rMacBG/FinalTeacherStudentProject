using TeacherStudentProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeacherStudentProject.Data.Models;

namespace TeacherStudentProject.Data.ApplicationContext
{
    
   public class SchoolLibDbContext : DbContext
    {
        public SchoolLibDbContext(DbContextOptions<SchoolLibDbContext> options)
       : base(options)
        {
        }

      
        public DbSet<Student> Students  { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
 
        public DbSet<Email> Emails { get; set; }
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-APPA48Q;Database=TeachersBook;Trusted_Connection=True");
        }
    }
}
