using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EStoreWebApp.Models;
using BLL;
using BOL;

namespace EStoreWebApp.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Product> prodList=ProductManager.GetAllProducts();
        ViewData["products"]=prodList;
        return View();
    }

}
