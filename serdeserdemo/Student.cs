namespace BOL;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

[Serializable]
public class Student{
    
    public int Id{get; set;}
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string Address{get; set;}

    public Student(int id,string fname,string lname,string addr){
        this.Id=id;
        this.FirstName=fname;
        this.LastName=lname;
        this.Address=addr;
    }
}