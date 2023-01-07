using Egovernance;
using Banking;

CentralGov cgov=new CentralGov();

TaxOperation DItax=new TaxOperation(cgov.DeductIncomeTax);
TaxOperation DStax=new TaxOperation(cgov.DeductServiceTax);
TaxOperation DPtax=new TaxOperation(cgov.DeductProfessionalTax);

//Console.WriteLine(DItax);
//DItax();    //unicaste delegate

// TaxOperation tax=null;
// tax=DItax;   // multicaste delegate
// tax+=DStax;
// tax();

Account acct=new Account(5000);
acct.overBalance+=DItax;
acct.overBalance+=DStax;
acct.overBalance+=DPtax;

// acct.Deposit(300000);

// acct.ProcessTax();
// Console.WriteLine(acct);

BankManager bm=new BankManager();

UnderBalOpr blockAcc=new UnderBalOpr(bm.BlockAccount);
UnderBalOpr email=new UnderBalOpr(bm.SendEmail);
UnderBalOpr sms=new UnderBalOpr(bm.SendSMS);
acct.underBalance+=blockAcc;
acct.underBalance+=email;
acct.underBalance+=sms;
//acct.Deposit(1000000);
//acct.ProcessTax();
acct.Withdraw(1000);
Console.WriteLine(acct);