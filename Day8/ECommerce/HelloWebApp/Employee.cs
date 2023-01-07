namespace HR;

public class Employee{
    public int Id{get; set;}
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public double Contact{get; set;}
    public string Email{get; set;}

    public Employee(int id, string firstName, string lastName, double contact, string email){
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Id=id;
        this.Contact=contact;
        this.Email=email;
    }
}