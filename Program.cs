using MySql.Data.MySqlClient;
using System.Data;

public class BdComun
{
   
    public static void Main(string[] args)
    {
        try
        {
            MySqlConnectionStringBuilder builder = new();
            builder.Server = "localhost";
            builder.Database = "mydb";
            builder.UserID = "root";
            builder.Password = "";

            Console.WriteLine("Conectado");


            using var connection = new MySqlConnection(builder.ToString());
            connection.Open();

            using var command = new MySqlCommand("SELECT `apellido` FROM `emple`");
            using var reader = command.ExecuteReader(); 
          
            Console.WriteLine(reader.ToString());



        }
        catch (Exception)
        {

            throw;
        }
        
        
    }
   
    
}


