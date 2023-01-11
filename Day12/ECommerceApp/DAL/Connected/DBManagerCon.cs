namespace DAL.Connected;
using BOL;
using MySql.Data.MySqlClient;


public class DBManagerCon{
    public static string conString=@"server=localhost;port=3307;user=root;password=root123;database=transflower";
    public static List<Department> GetAllDepartments(){
        List<Department> allDepartments= new List<Department>();
       
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;
            try{
                con.Open();
                //fire query to database
                MySqlCommand cmd=new MySqlCommand();
                cmd.Connection=con;
                string query="SELECT * FROM departments";
                cmd.CommandText=query;
                MySqlDataReader reader=cmd.ExecuteReader();
                while(reader.Read()){
                    int id = int.Parse(reader["id"].ToString());
                    string name = reader["name"].ToString();
                    string location = reader["location"].ToString();

                    Department dept=new Department(id,name,location);
                    allDepartments.Add(dept);
                }
            }
            catch(Exception ee){
                Console.WriteLine(ee.Message);
            }
            finally{
                    con.Close();
            }

            return allDepartments;

    }
}