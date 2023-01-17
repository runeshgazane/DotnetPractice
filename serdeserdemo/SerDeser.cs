namespace DAL;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using BOL;

public class SerDeser{
    public static string str=@"D:\IACSD\Daily_Practice\Dotnet_LocalRepo\DotnetPractice\serdeserdemo\data.json";
    public static List<Student> GetAllStudents(List<Student> studList) {
        var options=new JsonSerializerOptions{IncludeFields=false};
        var studentJson=JsonSerializer.Serialize<List<Student>>(studList,options);
        File.WriteAllText(str,studentJson);
        string jsonString=File.ReadAllText(str);
        List<Student> studentList=JsonSerializer.Deserialize<List<Student>>(jsonString);
        return studentList;
    }
}