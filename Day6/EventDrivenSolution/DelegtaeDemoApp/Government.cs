namespace Egovernance;

public delegate void TaxOperation(double amount);

public class CentralGov{
    public void DeductIncomeTax(double amount){
        Console.WriteLine("Inside DeductIncomeTax");
    }

    public void DeductServiceTax(double amount){
        Console.WriteLine("Inside DeductServiceTax");
    }

    public void DeductProfessionalTax(double amount){
        Console.WriteLine("Inside DeductProfessionalTax");
    }
}