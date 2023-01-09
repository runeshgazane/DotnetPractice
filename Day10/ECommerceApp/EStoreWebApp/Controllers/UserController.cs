using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BOL;
using BLL;

namespace EStoreWebApp.Controllers;

public class UserController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public UserController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

public IActionResult Login()
    {
        return View();
    }

public IActionResult Register()
    {
        return View();
    }

public IActionResult Validate(string email, string password)
    {
        User user=new User(email,password);
        if(UserManager.ValidateUser(user)){
            return Redirect("/Home/Index");
        }  
        else
            return Redirect("/User/Login");
    }

    public IActionResult StoreUser(string fname,string lname,string email, string password)
    {
        var user = new User(fname,lname,email,password);

        UserManager.RegisterUser(user);

        return Redirect("/User/Login");
    }
}