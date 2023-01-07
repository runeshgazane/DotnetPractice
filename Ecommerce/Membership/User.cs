namespace Membership;

public class User{
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string Email{get; set;}
    public int Contact{get; set;}
    public string Location{get; set;}
    public User(string firstName, string lastName, string email, int contact,string location){
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email=email;
        this.Contact=contact;
        this.Location=location;
    }
}