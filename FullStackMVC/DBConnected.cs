namespace DAL;

using BOL;
using MySql.Data.MySqlClient;

public class DBConnected{
    public static string conString = @"server=localhost;port=3306;user=root;password=root123;database=transflower";
    public static List<Employees> GetAllEmployees(){
        List<Employees> empList=new List<Employees>();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            con.Open();
            string query="SELECT * from employees";
            MySqlCommand cmd=new MySqlCommand(query,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while (reader.Read())
            {
                int id=int.Parse(reader["id"].ToString());
                string fname=reader["firstName"].ToString();
                string lname=reader["lastName"].ToString();
                string email=reader["email"].ToString();
                string addr=reader["address"].ToString();
                string passwd=reader["password"].ToString();
                int deptid=int.Parse(reader["deptid"].ToString());
                int mgrid=int.Parse(reader["managerid"].ToString());
                Employees emp=new Employees(id,fname,lname,email,addr,passwd,deptid,mgrid);
                empList.Add(emp);
            }
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return empList;
    }

    public static bool Insert(Employees emp){
        bool status=false;
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            con.Open();
            string query="insert into employees(firstName,lastName,email,address,password,deptid,managerid) values('"+emp.FirstName+"','"+
                    emp.LastName+"','"+emp.Email+"','"+emp.Address+"','"+emp.Password+
                    "','"+emp.Deptid+"','"+emp.Managerid+"')";
            MySqlCommand cmd=new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            status=true;
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return true;
    }

    public static bool Update(Employees emp){
        bool status=false;
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            con.Open();
            string query="update employees set firstName='"+emp.FirstName+"',lastName='"+
                    emp.LastName+"',email='"+emp.Email+"',address='"+emp.Address+"',password='"+emp.Password+
                    "',deptid='"+emp.Deptid+"',managerid='"+emp.Managerid+"'where id="+emp.Id;
            MySqlCommand cmd=new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            status=true;
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return true;
    }

    public static bool Delete(int id){
        bool status=false;
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            con.Open();
            string query="delete from employees where id="+id;
            MySqlCommand cmd=new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            status=true;
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return true;
    }

    public static List<Employees> Search(int id){
        bool status=false;
        List<Employees> empList=new List<Employees>();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
        try{
            con.Open();
            string query="select * from employees where id="+id;
            MySqlCommand cmd=new MySqlCommand(query,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while (reader.Read())
            {
                int empid=int.Parse(reader["id"].ToString());
                string fname=reader["firstName"].ToString();
                string lname=reader["lastName"].ToString();
                string email=reader["email"].ToString();
                string addr=reader["address"].ToString();
                string passwd=reader["password"].ToString();
                int deptid=int.Parse(reader["deptid"].ToString());
                int mgrid=int.Parse(reader["managerid"].ToString());
                Employees emp=new Employees(empid,fname,lname,email,addr,passwd,deptid,mgrid);
                empList.Add(emp);
            }
           
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return empList;
    }
}
