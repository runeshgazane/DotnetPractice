namespace HR;

public class SalesManager:SalesEmployee{
    public float Bonus{get; set;}

    public SalesManager(): base(){
        this.Bonus=0;
    }

    public SalesManager(int empid, string firstName, string lastName, int contact, string email,
                string location, DateTime bdate, float basicSal, float hra, float da,
                float salesdone,float bonus)
                :base(empid, firstName, lastName, contact, email, location, bdate, basicSal,
                hra, da, salesdone){
        this.Bonus=bonus;
    }

    public override void DoWork()
    {
        base.DoWork();
    }

    public override float ComputeSal()
    {
        return base.ComputeSal()+this.Bonus;
    }

    public override string ToString()
    {
        return base.ToString();
    }
}