namespace EStoreWebApp.Models;

public class Trainer{
    public string FirstName{get; set;}
    public string LastName{get; set;}

    public Trainer(string fname, string lname){
        this.FirstName=fname;
        this.LastName=lname;
    }

    
}