using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public ContentResult Details()
    {
        return Content("This is the About page where you can learn more about our application.");
    }
    public IActionResult Json()
    {
        var name = "About Page";

        return Json(new { data = name });

    }

}