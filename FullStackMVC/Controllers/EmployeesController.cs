using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FullStackMVC.Models;
using BOL;
using DAL;

namespace FullStackMVC.Controllers;

public class EmployeesController : Controller
{
    private readonly ILogger<EmployeesController> _logger;

    public EmployeesController(ILogger<EmployeesController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        List<Employees> empList=DBConnected.GetAllEmployees();
        ViewData["employees"]=empList;
        return View();
    }

    [HttpGet]
    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(string fname,string lname,string email,string addr,
                                string passwd,int deptid,int mgrid)
    {
        Employees emp=new Employees(fname,lname,email,addr,passwd,deptid,mgrid);
        DBConnected.Insert(emp);
        return RedirectToAction("index","employees");
    }

    [HttpGet]
    public IActionResult Update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Update(int id,string fname,string lname,string email,string addr,
                                string passwd,int deptid,int mgrid)
    {
        Employees emp=new Employees(id,fname,lname,email,addr,passwd,deptid,mgrid);
        DBConnected.Update(emp);
        return RedirectToAction("index","employees");
    }

    [HttpGet]
    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        DBConnected.Delete(id);
        return RedirectToAction("index","employees");
    }

    [HttpGet]
    public IActionResult Search()
    {
        return View();
    }

    public IActionResult Details(int id)
    {
        List<Employees> empList1=DBConnected.Search(id);
        ViewData["employee"]=empList1;
        return View();
    }

}
