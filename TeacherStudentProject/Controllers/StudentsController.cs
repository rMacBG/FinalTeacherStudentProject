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
using TeacherStudentProject.Services;
using TeacherStudentProject.Services.Interfaces;

namespace TeacherStudentProject.Controllers
{
    public class StudentsController : Controller 
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
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
        public async Task<IActionResult> Create([Bind("FirstName,Surname,FamilyName,Speciality,Grade,BirthDate,CreatedAt")]Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public async Task<IActionResult> Details(Guid id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
            
        }
        [Authorize]
        public async Task<IActionResult> Edit(Guid id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
            
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,Surname,FamilyName,Speciality,Grade,BirthDate,CreatedAt")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.UpdateAsync(id, student);
            return RedirectToAction(nameof(Index));
        }
        [Authorize]
        public async Task<IActionResult> Delete(Guid id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var studentDetails =  await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        
    }
}
