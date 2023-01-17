using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Catalog;

public class SerDeser
{
    string fileName = @"D:\Runesh_Saurav_DAC\dotnet\LabWork\Day5\TypeSolution\Catalog.json";
    public static List<Product> SerializeDeserializeList(List<Product> prodList)
    {
        var options = new JsonSerializerOptions { IncludeFields = false };
        var produtsJson = JsonSerializer.Serialize<List<Product>>(prodList, options);
        string fileName = @"D:\Runesh_Saurav_DAC\dotnet\LabWork\Day5\TypeSolution\Catalog.json";
        File.WriteAllText(fileName, produtsJson);
        string jsonString = File.ReadAllText(fileName);
        List<Product>? jsonProducts = JsonSerializer.Deserialize<List<Product>>(jsonString);
        return jsonProducts!;
    }
}