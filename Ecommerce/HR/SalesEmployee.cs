namespace HR;

public class SalesEmployee : Employee{
    public float Target{get; set;}
    public float Salesdone{get; set;}
    public float Incentive{get; set;}

    public SalesEmployee():base(){
        this.Target=0;
        this.Salesdone=0;
        this.Incentive=0;
    }

    public SalesEmployee(int empid, string firstName, string lastName, int contact, string email,
                    string location, DateTime bdate, float basicSal, float hra, float da,float salesdone):
                    base(empid, firstName, lastName, contact, email, location, bdate, basicSal, hra, da){
        this.Target=5000;
        this.Salesdone=salesdone;
        this.Incentive=0;
    }

    public override void DoWork()
    {
        if(this.Salesdone>=this.Target){
            this.Incentive=5000;
        }
    }

    public override float ComputeSal()
    {
        return base.ComputeSal()+this.Incentive;
    }

    public override string ToString()
    {
        return base.ToString()+" Target="+this.Target+" Incentive="+this.Incentive;
    }

}