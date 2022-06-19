using FinalTeacherStudentProject.Data.ApplicationContext;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeacherStudentProject.Data.Models;

namespace TeacherStudentProject.Controllers
{
    public class AccountsController : Controller
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;
        //private readonly SchoolLibDbContext _context;

        //public AccountsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, SchoolLibDbContext context)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //    _context = context;
        //}

        //public async Task<IActionResult> Users()
        //{
        //    var users = await _context.Users.ToListAsync();
        //    return View(users);
        //}
        //    public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
