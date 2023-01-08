using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tflstore.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tflstore.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult DisplayProducts(){
        ProductManager.GetAllProducts();
        var fileName=@"D:\IACSD\Daily_Practice\Dotnet_LocalRepo\DotnetPractice\Day8\ECommerce\tflstore\prodlist.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<Product> jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
        Console.WriteLine("data is deserialized");  

        ViewData["catalog"]=jsonProducts;
        return View();
    }
}
