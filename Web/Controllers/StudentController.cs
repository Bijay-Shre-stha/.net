using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }


    public IActionResult Index()
    {
        return View();
    }

    public IActionResult StudentCard()
    {
        var Student = new Student
        {
            Id = 1,
            Name = "John Doe",
            Age = 20,
            Major = "Computer Science"
        };
        return PartialView("_StudentCard", Student);
    }

    public ViewResult viewResult()
    {
        return View("About");
    }

}
