namespace BLL;
using BOL;
using DAL;
public class UserManager{
    public static void RegisterUser(User user){
        DBUserManager.RegisterNewUser(user);
    }

    public static bool ValidateUser(User user){
        List<User> userList=DBUserManager.GetUserList();
        foreach(User u in userList){
            if(user.Email==u.Email && user.Password==u.Password){
                return true;
            }  
        }
        return false;
    }
}