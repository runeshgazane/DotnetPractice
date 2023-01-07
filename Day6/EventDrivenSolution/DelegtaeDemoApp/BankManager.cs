namespace Banking;

public delegate void UnderBalOpr();
public class BankManager{
    public void BlockAccount(){
        Console.WriteLine("Your account is blocked.");
    }

    public void SendEmail(){
        Console.WriteLine("Email sent");
    }

    public void SendSMS(){
        Console.WriteLine("SMS sent");
    }
}