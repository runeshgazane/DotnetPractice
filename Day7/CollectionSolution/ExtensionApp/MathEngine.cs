namespace Mathematics;

public class MathEngine{

    public int Id{get; set;}
    public int Result{get;set;}
    public int Addition(int num1, int num2){
        return num1+num2;
    }

    public int Subtraction(int num1, int num2){
        return num1-num2;
    }
}