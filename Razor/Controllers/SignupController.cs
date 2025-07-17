using Microsoft.AspNetCore.Mvc;

namespace Razor.Controllers;

public class SignupController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Web.Models.Signup signup)
    {
        if (ModelState.IsValid)
        {
            ViewBag.Message = signup.Name + " Signup successful!";
            return View();
        }

        return View(signup);
    }

}