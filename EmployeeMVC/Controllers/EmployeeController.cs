using Microsoft.AspNetCore.Mvc;


[Route("Employee")]
public class EmployeeController : Controller
{
    private readonly ILogger<EmployeeController> _logger;

    public EmployeeController(ILogger<EmployeeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("Index")]
    public IActionResult Index()
    {
        return View();
    }

    [Route("Details/{id}")]
    public IActionResult Details(int id)
    {
        // Logic to retrieve employee details by id
        return View();
    }

    [HttpGet("~/EmployeeDetails/all")]
    public IActionResult AllEmployees()
    {
        return View();
        
    }


}