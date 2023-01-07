namespace tflstore.Models;

public class UserCatalog{
    public static List<User> userList=new List<User>();
    public static List<User> addUser(User newUser){
        userList.Add(newUser);
        return userList;
    }
}