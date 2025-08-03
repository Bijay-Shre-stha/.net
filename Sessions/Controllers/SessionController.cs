using Microsoft.AspNetCore.Mvc;
using Sessions.Models;

namespace Sessions.Controllers;

public class SessionController : Controller
{
    [Route("/")]
    public IActionResult Index()
    {
        HttpContext.Session.SetString("Name", "Bijay Shrestha");
        HttpContext.Session.SetString("Age", "22");

        User user = new User
        {
            Name = HttpContext.Session.GetString("Name"),
            Age = int.Parse(HttpContext.Session.GetString("Age"))
        };

        return View(user);
    }

    public IActionResult GetQueryString(string name, int age)
    {
        User user = new User
        {
            Name = name,
            Age = age
        };
        return View("Details", user);
    }


    [HttpGet]
    public IActionResult SetHiddenFieldValue()
    {
        User user = new User()
        {
            Id = 1209,
            Name = "Bijay Shrestha",
            Age = 22
        };
        return View("Hidden", user);
    }
    [HttpPost]
    public IActionResult SetHiddenFieldValue(User user)
    {
        var id = user.Id;
        ViewBag.ID = id;
        return View("Hidden", user);
    }
}

