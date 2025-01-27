using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using UniversityManagementSystemMvc.Data;
using UniversityManagementSystemMvc.Models;

namespace UniversityManagementSystemMvc.Controllers;

public class AdminController : Controller
{
    private readonly UniversityManagementSystemMvcContext _context;
    public AdminController(UniversityManagementSystemMvcContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    // ----------------------- Admin Login -----------------------      
    public IActionResult UserProcessing()
    {
        return View();
    }
    
    public IActionResult Course()
    {
        return View();
    }
    
    public IActionResult Notifications()
    {
        return View();
    }
    
    public IActionResult RecordManagement()
    {
        return View();
    }



    // [HttpPost]
    // public IActionResult Admin(string userName, string password)
    // {
    //     return Enter(userName, password);
    // }
    
    // // ----------------------- Academician Login -----------------------  
    // public IActionResult Academician()
    // {
    //     return View();
    // }
    // [HttpPost]
    // public IActionResult Academician(string userName, string password)
    // {
    //     return Enter(userName, password);
    // }

    // // ----------------------- Student Login -----------------------  
    // public IActionResult Student()
    // {
    //     return View();
    // }

    // [HttpPost]
    // public IActionResult Student(string userName, string password)
    // {
    //     return Enter(userName, password);
    // }

    // // ----------------------- Partner Methods -----------------------  
    // IActionResult Enter(string userName, string password)
    // {
    //     var user = _context.tblStudents.
    //     FirstOrDefault(u => u.UserName == userName && u.Password == password);
    //     if (user != null)
    //     {
    //         switch (user.Role)
    //         {
    //             case UserRole.Admin:
    //                 return RedirectToAction("Index", "Home");
    //             case UserRole.Academician:
    //                 return RedirectToAction("Index", "Home");
    //             case UserRole.Student:
    //                 return RedirectToAction("Index", "Home");
    //             default:
    //                 return View();
    //         }
    //     }
    //     else
    //         return View();
    // }
}
