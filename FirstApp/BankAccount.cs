namespace Bank;
class Account
{
    private int accountNo;
    private double balance;

    public Account()
    {
        accountNo = 101;
        balance = 10000;
    }

    public Account(int accountNo, double balance)
    {
        this.accountNo = accountNo;
        this.balance = balance;
    }

    public int AccountNo
    {
        get { return this.accountNo; }
        set { this.accountNo = value; }
    }

    public double Balance
    {
        get { return this.balance; }
        set { this.balance = value; }
    }

    public void Deposit(double amount)
    {
        this.balance = this.balance + amount;
    }

    public void Withdraw(double amount)
    {
        if ((this.balance - 10000) < amount)
            throw new System.Exception("Insufficient Balance");
        this.balance = this.balance + amount;
    }
}