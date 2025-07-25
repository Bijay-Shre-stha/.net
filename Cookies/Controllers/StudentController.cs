using Microsoft.AspNetCore.Mvc;

namespace Cookies.Controllers;

public class StudentController : Controller
{
    public IActionResult Index()
    {
        string userName = Request.Cookies["UserName"];
        return View("Index", userName);
    }


    [HttpPost]
    public IActionResult Index(IFormCollection form)
    {
        string UserName = form["UserName"].ToString();

        CookieOptions option = new CookieOptions();
        option.Expires = DateTime.Now.AddMinutes(5);
        Response.Cookies.Append("UserName", UserName, option);
        return RedirectToAction(nameof(Index));
    }


    public IActionResult Delete()
    {
        Response.Cookies.Delete("UserName");
        return RedirectToAction(nameof(Index));
    }

}