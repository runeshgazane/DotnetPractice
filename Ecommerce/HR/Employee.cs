namespace HR;


public abstract class Employee 
{
    public int Empid{get; set;}
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public int Contact {get; set;}
    public string Email {get; set;}
    public string Location {get; set;}
    public DateTime DOB {get; set;}
    public float BasicSal{get; set;}
    public float HRA{get; set;}
    public float DA{get; set;}

    public Employee():this(100,"ABC","XYZ",1234567890,"abc@gmail.com","Mumbai",new DateTime(2000,1,1),10000,1000,1000){

    }

    public Employee(int empid, string firstName, string lastName, int contact, string email,
                    string location, DateTime bdate, float basicSal, float hra, float da){
        this.Empid=empid;
        this.FirstName=firstName;
        this.LastName=lastName;
        this.Email=email;
        this.Contact=contact;
        this.Location=location;
        this.DOB=bdate;
        this.BasicSal=basicSal;
        this.HRA=hra;
        this.DA=da;
    }

    public abstract void DoWork();

    public virtual float ComputeSal(){
        return this.BasicSal+this.HRA+this.DA;
    }

    public override string ToString()
    {
        return this.Empid+" "+this.FirstName+" "+this.LastName+" Basic salary="+this.BasicSal;
    }
}
    
