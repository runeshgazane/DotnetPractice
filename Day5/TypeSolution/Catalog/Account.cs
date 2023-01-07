using System.Text.Json;
using System.Text.Json.Serialization;
public class Account{
    
    private int accNo;
    private int branchId;
   
   [JsonInclude]
    public int AccNo{
        get{return this.accNo;}
        set{this.accNo=value;}
    }

    public int BranchId{
        get{return this.branchId;}
        set{this.branchId=value;}
    }

    public Account(int accNo, int branchId){
        this.AccNo=accNo;
        this.BranchId=branchId;
    }

    public override string ToString()
    {
        return this.accNo+" "+this.branchId;
    }
}