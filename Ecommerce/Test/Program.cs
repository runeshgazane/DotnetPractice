using Membership;
using HR;

// Console.WriteLine("Enter EmailId : ");
// string email = Console.ReadLine();
// Console.WriteLine("Enter Password : ");
// string password = Console.ReadLine();
// if(AuthManager.Validate(email,password)){
//     Console.WriteLine("Logged in successfully.");
// }
// else{
//     Console.WriteLine("Invalid login details...");
// }

// if(AuthManager.Register("Runesh", "Gazane", "rg@gmail.com", 1234567890, "pune")){
//     Console.WriteLine("User registered successfully");
// }
// else{
//      Console.WriteLine("User registration failed");
// }

// Employee emp=new SalesEmployee(11,"Runesh","Gazane",784512,"rg@gmail.com","Pune",
//                                 new DateTime(1996,1,13),20000,5000,2000,7000);
// emp.DoWork();
// float salary=emp.ComputeSal();
// Console.WriteLine("Salary="+salary);
// Console.WriteLine(emp);

Employee emp=new SalesManager(11,"Runesh","Gazane",784512,"rg@gmail.com","Pune",
                            new DateTime(1996,1,13),20000,5000,3000,7000,10000);
emp.DoWork();
float salary=emp.ComputeSal();
Console.WriteLine("Salary="+salary);
Console.WriteLine(emp);