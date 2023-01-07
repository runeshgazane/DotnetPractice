using Catalog;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

bool flag = false;

Product p1 = new Product();
Product p2 = new Product(2, "Monitor", "IO Device", 20000);
Product p3 = new Product(3, "CPU", "IO Device", 25000);
Product p4 = new Product(4, "Mouse", "IO Device", 5000);

List<Product> prodList = new List<Product>();

prodList.Add(p1);
prodList.Add(p2);
prodList.Add(p3);
prodList.Add(p4);


// foreach(Product p in prodList){
//     Console.WriteLine(p);
// }


while (!flag)
{
    Console.WriteLine("1.GetById 2.Insert 3.Update 4.Delete 5.GetAll 6.Exit");
    switch (int.Parse(Console.ReadLine()!))
    {
        case 1:
            Console.WriteLine("Enter id");
            Product? getProd = Product.GetById(int.Parse(Console.ReadLine()!), prodList!);
            if (getProd == null)
                Console.WriteLine("Product doesn't exist");
            else
                Console.WriteLine(getProd);
            break;
        case 2:
            Product.Insert(prodList);
            break;
        case 3:
            Console.WriteLine("Enter id");
            Product.Update(int.Parse(Console.ReadLine()!), prodList);
            break;
        case 4:
            Console.WriteLine("Enter id");
            Product.Delete(int.Parse(Console.ReadLine()!), prodList);
            break;
        case 5:
            Product.GetAll(prodList);
            break;
        case 6:
            flag = true;
            break;
        default:
            Console.WriteLine("Invalid Input");
            break;
    }
}




