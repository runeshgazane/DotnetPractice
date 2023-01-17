namespace BOL;

public class Employees{
    public int Id{get; set;}
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public string Email{get; set;}
    public string Address{get; set;}
    public string Password{get; set;}
    public int Deptid{get; set;}
    public int Managerid{get; set;}

    public Employees(int id,string fname,string lname,string email,string addr,
                    string passwd,int deptid,int mgrid){
        this.Id=id;
        this.FirstName=fname;
        this.LastName=lname;
        this.Email=email;
        this.Address=addr;
        this.Password=passwd;
        this.Deptid=deptid;
        this.Managerid=mgrid;
    }

    public Employees(string fname,string lname,string email,string addr,
                    string passwd,int deptid,int mgrid){
        this.FirstName=fname;
        this.LastName=lname;
        this.Email=email;
        this.Address=addr;
        this.Password=passwd;
        this.Deptid=deptid;
        this.Managerid=mgrid;
    }
}