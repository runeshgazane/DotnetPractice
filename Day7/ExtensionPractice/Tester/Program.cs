using Maths;
// MathOperations m1 =new MathOperations();
// Console.WriteLine(m1.Add(10,20));
// Console.WriteLine(m1.Sub(10,20));
// Console.WriteLine(m1.h1.Multiply(10,20));
// Console.WriteLine(m1.h1.Divide(10,20));

// int[] arr=new int[]{10,20,30,40,50,20,10,40};
// Console.WriteLine(arr.Count());
// Console.WriteLine(arr.Distinct().Count());
// IEnumerable<int> numarr=arr.Skip(2);
// foreach(var i in numarr){
//     Console.WriteLine(i);
// }

string[] students={"Runesh", "Saurav", "ram", "Abhishek", "Runesh"};
var selectedStudents=from student in students where student.Contains("/[Rr]/") select student;
foreach(var i in selectedStudents){
   Console.WriteLine(i);
}
