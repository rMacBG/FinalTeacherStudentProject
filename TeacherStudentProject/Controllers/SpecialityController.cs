using TeacherStudentProject.Data.ApplicationContext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeacherStudentProject.Controllers
{
    public class SpecialityController : Controller
    {
        private readonly SchoolLibDbContext _context;
        public SpecialityController(SchoolLibDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
        //    var data = _context.Specialities.ToList();
        //    return View();
        //}
    }
}
