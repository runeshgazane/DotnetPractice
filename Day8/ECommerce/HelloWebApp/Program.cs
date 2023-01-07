using HR;
//namespace System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Employee> empList=new List<Employee>();
empList.Add(new Employee(11,"Runesh","Gazane",1234567891,"rg@gmail.com"));
var emp=new {Id=15, Firstname = "Runesh", Lastname = "Gazane"};

app.MapGet("/", () => "Hello World!");
app.MapGet("/employees", () => empList);
app.MapGet("/employee", () => emp);

app.Run();
