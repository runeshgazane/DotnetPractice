using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;

namespace EStoreWebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Mentor(){
        List<Trainer> trainers=new List<Trainer>();
        //var trainer=new {FirstName="Runesh", LastName="Gazane"};

        trainers.Add(new Trainer("Runesh", "Gazane"));
        trainers.Add(new Trainer("Saurav", "Patil"));
        return Json(trainers);
    }

    public IActionResult Aboutus(){
        return View();
    }

    public IActionResult Services(){
        List<string> services=new List<string>();
        services.Add("CDAC Mentoring");
        services.Add("Corporate Trainings");
        services.Add("DevCamps");
        services.Add("Skillbased Learning Program");
        services.Add("Consulting");
        ViewBag.trainings=services;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
