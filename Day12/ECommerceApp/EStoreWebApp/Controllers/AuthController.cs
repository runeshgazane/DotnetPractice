using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;

using BOL;
using BLL;

namespace EStoreWebApp.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;

    public AuthController(ILogger<AuthController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login(){
        Console.WriteLine("Login GET method is invoked at server side");
        return View();
    }

    [HttpPost]
    public IActionResult Login(string email, string password){
        Console.WriteLine("Login Post method is invoked at server side");
        if(email=="runeshgazane@gmail.com" && password=="dac123"){
            return RedirectToAction("Index","Departments");
        }
        return View();
    }

}