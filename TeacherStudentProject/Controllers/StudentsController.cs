using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalTeacherStudentProject.Data.ApplicationContext;
using FinalTeacherStudentProject.Data.Models;
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
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FirstName,Surname,FamilyName,Speciality,Grade,BirthDate,Id,CreatedAt")]Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(string id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
            
        }
        public async Task<IActionResult> Edit(string id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
            
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,Surname,FamilyName,Speciality,Grade,BirthDate,Id,CreatedAt")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            await _service.UpdateAsync(id, student);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(string id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var studentDetails =  await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //    {
        //        private readonly SchoolLibDbContext _context;


        //        public StudentsController(SchoolLibDbContext context)
        //        {
        //            _context = context;
        //        }


        //        public async Task<IActionResult> Index()
        //        {
        //            return View(await _context.Students.ToListAsync());
        //        }


        //        public async Task<IActionResult> Details(string id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var student = await _context.Students
        //                .FirstOrDefaultAsync(m => m.Id == id);
        //            if (student == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(student);
        //        }


        //        public IActionResult Create()
        //        {
        //            return View();
        //        }


        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Create([Bind("FirstName,Surname,FamilyName,Speciality,Grade,BirthDate,Id,CreatedAt,EditedAt,DeletedAt")] Student student)
        //        {
        //            if (ModelState.IsValid)
        //            {
        //                _context.Add(student);
        //                await _context.SaveChangesAsync();
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(student);
        //        }


        //        public async Task<IActionResult> Edit(string id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var student = await _context.Students.FindAsync(id);
        //            if (student == null)
        //            {
        //                return NotFound();
        //            }
        //            return View(student);
        //        }


        //        [HttpPost]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> Edit(string id, [Bind("FirstName,Surname,FamilyName,Speciality,Grade,BirthDate,Id,CreatedAt,EditedAt,DeletedAt")] Student student)
        //        {
        //            if (id != student.Id)
        //            {
        //                return NotFound();
        //            }

        //            if (ModelState.IsValid)
        //            {
        //                try
        //                {
        //                    _context.Update(student);
        //                    await _context.SaveChangesAsync();
        //                }
        //                catch (DbUpdateConcurrencyException)
        //                {
        //                    if (!StudentExists(student.Id))
        //                    {
        //                        return NotFound();
        //                    }
        //                    else
        //                    {
        //                        throw;
        //                    }
        //                }
        //                return RedirectToAction(nameof(Index));
        //            }
        //            return View(student);
        //        }

        //        // GET: Students/Delete/5
        //        public async Task<IActionResult> Delete(string id)
        //        {
        //            if (id == null)
        //            {
        //                return NotFound();
        //            }

        //            var student = await _context.Students
        //                .FirstOrDefaultAsync(m => m.Id == id);
        //            if (student == null)
        //            {
        //                return NotFound();
        //            }

        //            return View(student);
        //        }

        //        // POST: Students/Delete/5
        //        [HttpPost, ActionName("Delete")]
        //        [ValidateAntiForgeryToken]
        //        public async Task<IActionResult> DeleteConfirmed(string id)
        //        {
        //            var student = await _context.Students.FindAsync(id);
        //            _context.Students.Remove(student);
        //            await _context.SaveChangesAsync();
        //            return RedirectToAction(nameof(Index));
        //        }

        //        private bool StudentExists(string id)
        //        {
        //            return _context.Students.Any(e => e.Id == id);
        //        }
        //    }
        //}
    }
}
