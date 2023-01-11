using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;

namespace EStoreWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(){
        return View();
    }

    public IActionResult Insert(){
        Console.WriteLine("Inside get insert");
        Product prod=new Product();
        return View(prod);
    }

    [HttpPost]
    public IActionResult Insert(Product newProduct){
         Console.WriteLine("Inside post insert");
        Console.WriteLine(newProduct.Id+" "+newProduct.Title);
        if(!ModelState.IsValid){
            return View();
        }
        Console.WriteLine(newProduct.Id+" "+newProduct.Title);
        return RedirectToAction("Index","Home");
    }

}