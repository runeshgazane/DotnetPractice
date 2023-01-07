using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tflstore.Controllers;

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

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Validate(string email, string password)
    {
        var fileName=@"D:\Runesh_Saurav_DAC\dotnet\LabWork\Day8\ECommerce\tflstore\data.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<DataRegister> jsonProducts = JsonSerializer.Deserialize<List<DataRegister>>(jsonString);
        Console.WriteLine(jsonProducts);
        if(email=="runeshgazane@gmail.com" && password=="dac123"){
            return Redirect("/home/Welcome");
        }
        return View();
    }

    public IActionResult Welcome()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult StoreData(string fname,string lname,string contact,string addr)
    {
        var data = new DataRegister(){Firstname=fname,LastName=lname,Contact=contact,Address=addr};
        List<DataRegister> list=new List<DataRegister>();
        list.Add(data);
        var options = new JsonSerializerOptions { IncludeFields = false };
        var dataJson = JsonSerializer.Serialize<List<DataRegister>>(list, options);
        string fileName = @"D:\Runesh_Saurav_DAC\dotnet\LabWork\Day8\ECommerce\tflstore\data.json";
        System.IO.File.AppendAllText(fileName,dataJson);
        return Redirect("/home/Register");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
