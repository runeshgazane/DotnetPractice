using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tflstore.Controllers;

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
        var fileName=@"D:\Runesh_Saurav_DAC\dotnet\LabWork\Day8\ECommerce\tflstore\data.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<User> jsonUser = JsonSerializer.Deserialize<List<User>>(jsonString);
         Console.WriteLine("data is deserialized");
        foreach(User u in jsonUser){
            Console.WriteLine(u.Email+" "+u.Password);
            if(email==u.Email && password==u.Password){
                return Redirect("/Home/Welcome");
            }  
        }
        return Redirect("/User/Login");
    }

    public IActionResult StoreData(string fname,string lname,string email, string password,
                                    string contact,string addr)
    {
        var user = new User(){FirstName=fname,LastName=lname,Email=email,
                                Password=password,Contact=contact,Address=addr};

        List<User> updatedList=UserCatalog.addUser(user);

        var options = new JsonSerializerOptions { IncludeFields = false };
        var dataJson = JsonSerializer.Serialize<List<User>>(updatedList, options);
        string fileName = @"D:\Runesh_Saurav_DAC\dotnet\LabWork\Day8\ECommerce\tflstore\data.json";
        System.IO.File.WriteAllText(fileName,dataJson);
        return Redirect("/User/Login");
    }
}