namespace Catalog;
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;

[Serializable]
public class Product
{
    public int ProdId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public float UnitPrice { get; set; }

    public Product() : this(1, "ABC", "XYZ", 100)
    {

    }

    public Product(int id, string title, string desc, float price)
    {
        this.ProdId = id;
        this.Title = title;
        this.Description = desc;
        this.UnitPrice = price;
    }

    public static Product? GetById(int id, List<Product> pList)
    {
        foreach (Product p in pList)
        {
            if (p.ProdId == id)
            {
                return p;
            }
        }
        return null;
    }

    public static void Insert(List<Product> prodList)
    {
        Console.WriteLine("Enter id, title, description, price");
        prodList.Add(new Product(int.Parse(Console.ReadLine()!), Console.ReadLine()!,
                    Console.ReadLine()!, float.Parse(Console.ReadLine()!)));
        Console.WriteLine("Product inserted");
    }
    public static void Update(int id, List<Product> prodList)
    {
        Product? updateProd = Product.GetById(id, prodList!);
        if (updateProd == null)
        {
            Console.WriteLine("Product doesn't exist");
            return;
        }
        else
        {
            Console.WriteLine("Enter id, title, description, price");
            updateProd.ProdId = int.Parse(Console.ReadLine()!);
            updateProd.Title = Console.ReadLine()!;
            updateProd.Description = Console.ReadLine()!;
            updateProd.UnitPrice = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Product updated");
            SerDeser.SerializeDeserializeList(prodList);
        }
    }

    public static void Delete(int id, List<Product> prodList)
    {
        Console.WriteLine("Enter id");
        Product? deleteProd = Product.GetById(id, prodList!);
        if (deleteProd == null){
            Console.WriteLine("Product doesn't exist");
            return;
        }
        else
        {
            prodList.Remove(deleteProd);
            Console.WriteLine("Product removed");
        }
        SerDeser.SerializeDeserializeList(prodList);
    }

    public static void GetAll(List<Product> prodList){
        foreach(Product p in prodList){
            Console.WriteLine(p);
        }
    }

    public override string ToString()
    {
        return this.ProdId + " " + this.Title + " " + this.Description + " " + this.UnitPrice;
    }
}