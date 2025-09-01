using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login_Authentication.Models;
using Microsoft.AspNetCore.Identity;

namespace AccountAuthentication.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public AccountController(UserManager<IdentityUser> userManager,
    SignInManager<IdentityUser> signInManager)
    {
        this._userManager = userManager;
        this._signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginModel loginModel)
    {
        var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
        if (result.Succeeded)
        {
            if (!string.IsNullOrEmpty(Request.Query["ReturnUrl"]))
            {
                return Redirect(Request.Query["ReturnUrl"]);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
        }
        return View(loginModel);
    }

    [HttpPost]
    public async Task<IActionResult> Register(RegisterModel registerModel)
    {
        if (ModelState.IsValid)
        {
            var user = new IdentityUser
            {
                UserName = registerModel.Email,
                Email = registerModel.Email
            };
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }
        return View(registerModel);
    }

    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return RedirectToAction("Login", "Account");
    }
}

