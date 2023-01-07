namespace Banking;
using Egovernance;

public class Account{
    public event TaxOperation? overBalance;
    public event UnderBalOpr underBalance;
    public double Balance{get; set;}

    public Account(double balance){
        this.Balance=balance;
    }

    public void Deposit(double amount){
        this.Balance+=amount;
    }

    public void Withdraw(double amount){
        if(this.Balance<=5000){
            underBalance();
        }
        else
            this.Balance-=amount;
    }

    public override string ToString(){
        return "Current Balance = "+this.Balance;
    }

    public void ProcessTax(){
        if(this.Balance>=250000){
            overBalance(this.Balance);
        }
    }
}