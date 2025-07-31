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
}

