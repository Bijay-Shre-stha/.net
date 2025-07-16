using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace NCC_MVC.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public ContentResult Details()
    {
        return Content("This is the Student page where you can learn more about student management.");
    }

    public IActionResult Json()
    {
        var StudentData = new
        {
            Id = 1,
            Name = "John Doe",
            Age = 20,
            Batch = 2026
        };
        return Json(StudentData);
    }

    public IActionResult About()
    {
        return View("About");
    }
    public IActionResult StudentCard()
    {
        var student = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "John Doe",
                Age = 20,
                Batch = 2026
            },
            new Student
            {
                Id = 2,
                Name = "Jane Smith",
                Age = 22,
                Batch = 2024
            },
            new Student
            {
                Id = 3,
                Name = "Alice Johnson",
                Age = 21,
                Batch = 2025
            },
            new Student
            {
                Id = 4,
                Name = "Bob Brown",
                Age = 23,
                Batch = 2023
            }
        };

        return PartialView("_StdCard", student);
    }
}