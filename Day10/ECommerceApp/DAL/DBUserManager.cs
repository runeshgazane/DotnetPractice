namespace DAL;
using BOL;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DBUserManager{
    private static List<User> updatedList=new List<User>();

    public static void RegisterNewUser(User user){
    updatedList.Add(user);
    var options = new JsonSerializerOptions { IncludeFields = false };
    var dataJson = JsonSerializer.Serialize<List<User>>(updatedList, options);
    string fileName = @"D:\Runesh_Saurav_DAC\Dotnet_Runesh\DotnetPractice\Day10\ECommerceApp\userdir.json";
    System.IO.File.WriteAllText(fileName,dataJson);
    }

    public static List<User> GetUserList()
    {
        var fileName=@"D:\Runesh_Saurav_DAC\Dotnet_Runesh\DotnetPractice\Day10\ECommerceApp\userdir.json";
        string jsonString = System.IO.File.ReadAllText(fileName);
        List<User> jsonUser = JsonSerializer.Deserialize<List<User>>(jsonString);
        return jsonUser;
    }
}