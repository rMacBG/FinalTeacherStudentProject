using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TeacherStudentProject.Data.ApplicationContext;
using TeacherStudentProject.Data.Models;
using TeacherStudentProject.Data.Services.Interfaces;

namespace TeacherStudentProject.Controllers
{
    public class TeachersController : Controller
    {
        private readonly ITeacherService _service;

        public TeachersController(ITeacherService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]

        public async Task<IActionResult> Create([Bind("FirstName,Surname,FamilyName,BirthDate,CreatedAt")] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }
            await _service.AddAsync(teacher);
            return RedirectToAction(nameof(Index));
        }
        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }
        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,Surname,FamilyName,BirthDate,CreatedAt")] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }
            await _service.UpdateAsync(id, teacher);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Delete(Guid id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }


        //public async Task<IActionResult> Filter(string searchString)
        //{
        //    var allTeachers = await _service.GetAllAsync(n => n.FirstName);

        //    if (!string.IsNullOrEmpty(searchString))
        //    {


        //        var filteredResult = allTeachers.Where(n => string.Equals(n.FirstName, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Surname, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.FamilyName, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

        //        return View("Index", filteredResult);
        //    }
        //
        // return View("Index", allTeachers);
        //}

    
        
    }
}
