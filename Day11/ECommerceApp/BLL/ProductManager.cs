namespace BLL;
using BOL;
using DAL;
public class ProductManager{
    public static List<Product> GetAllProducts(){
        List<Product> productList=DBManager.GetAllProductsFromDB();
        return productList;
    }
}