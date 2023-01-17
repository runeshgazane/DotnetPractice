using BOL;
using DAL;

List<Student> studList=new List<Student>();
studList.Add(new Student(1,"Runesh","Gazane","Dighi"));
studList.Add(new Student(2,"Neha","Pednekar","Dighi"));
studList.Add(new Student(3,"Tanvi","Shivalkar","Ratnagiri"));
studList.Add(new Student(4,"Sakshi","Waingankar","Ratnagiri"));
List<Student> List=SerDeser.GetAllStudents(studList);
foreach (Student s in List)
{
    Console.WriteLine(s.Id+" "+s.FirstName);
}
