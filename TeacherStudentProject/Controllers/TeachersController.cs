﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalTeacherStudentProject.Data.ApplicationContext;
using FinalTeacherStudentProject.Data.Models;
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

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Create([Bind("FirstName,Surname,FamilyName,BirthDate,Id,CreatedAt")] Teacher teacher)
        {
            if (!ModelState.IsValid)
           {
              await _service.AddAsync(teacher);
               return RedirectToAction(nameof(Index));
           }
           return View(teacher);
        }

        public async Task<IActionResult> Details(string id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, [Bind("FirstName,Surname,FamilyName,BirthDate,Id,CreatedAt")] Teacher teacher)
        {
            if (!ModelState.IsValid)
            {
                return View(teacher);
            }
            await _service.UpdateAsync(id, teacher);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(string id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");
            return View(teacherDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var teacherDetails = await _service.GetByIdAsync(id);
            if (teacherDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
        //////////////////////////////////////////////////////////
        //private readonly SchoolLibDbContext _context;

        //public TeachersController(SchoolLibDbContext context)
        //{
        //    _context = context;
        //}

        //// GET: Teachers
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.Teachers.ToListAsync());
        //}

        //// GET: Teachers/Details/5
        //public async Task<IActionResult> Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var teacher = await _context.Teachers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (teacher == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(teacher);
        //}

        //// GET: Teachers/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("FirstName,Surname,FamilyName,BirthDate,Id,CreatedAt")] Teacher teacher)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(teacher);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(teacher);
        //}


        //public async Task<IActionResult> Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var teacher = await _context.Teachers.FindAsync(id);
        //    if (teacher == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(teacher);
        //}


        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(string id, [Bind("FirstName,Surname,FamilyName,BirthDate,Id,CreatedAt")] Teacher teacher)
        //{
        //    if (id != teacher.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(teacher);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!TeacherExists(teacher.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(teacher);
        //}

        //// GET: Teachers/Delete/5
        //public async Task<IActionResult> Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var teacher = await _context.Teachers
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (teacher == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(teacher);
        //}

        //// POST: Teachers/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(string id)
        //{
        //    var teacher = await _context.Teachers.FindAsync(id);
        //    _context.Teachers.Remove(teacher);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool TeacherExists(string id)
        //{
        //    return _context.Teachers.Any(e => e.Id == id);
        //}
    }
}
