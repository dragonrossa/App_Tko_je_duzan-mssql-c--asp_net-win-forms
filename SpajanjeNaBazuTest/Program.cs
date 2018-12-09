using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SpajanjeNaBazuTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //string connetionString = null;




            //connetionString = "SERVER=.\\SQLEXPRESS;" +
            //"Network Library=DBMSSOCN;" +
            //"Initial Catalog=UnosPrijatelja;" +
            //"Integrated Security = true;";

            //connetionString = "Data Source=IP_ADDRESS,PORT;"
            //Network Library = DBMSSOCN; Initial Catalog = DatabaseName;
            //User ID = UserName; Password = Password";



            //connetionString = "Data Source=127.0.0.1,1433;Initial Catalog=UnosPrijatelja;User ID=kikica_66@hotmail.com;Password= Windows Authentication";

            //cnn = new SqlConnection(connetionString);

            SqlConnection cnn;

            cnn = new SqlConnection("SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;");

                cnn.Open();
                Console.WriteLine("Connection Open !"); 
                cnn.Close();
            
        }
    }
}
