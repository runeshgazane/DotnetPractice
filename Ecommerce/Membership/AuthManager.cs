namespace Membership;
public static class AuthManager
{
    public static bool Validate(string email, string password){
        if(email.Equals("sp@gmail.com") && password.Equals("ditiss")){
            return true;
        }
        return false;
    }

    public static bool Register(string firstName, string lastName, string email, int contact,
                                string location){
        User newUser=new User(firstName,lastName,email,contact,location);
        return true;
    }
}
