using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

namespace Unos_prijatelja
{
    public partial class ProgramSeven : Prijatelj
    {
        static public void Seven ()
        {


            //Stvaramo bazu podataka ako je nema odnosno odbacujemo ako već postoji - ovo radi, ali mora biti Database = master i baza ne smije imati tablicu


            SqlConnection cnn;

            cnn = new SqlConnection("SERVER=.\\SQLEXPRESS;Database=master;Integrated Security=true;");

            cnn.Open();

            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("\nVeza je otvorena!");

            Console.Write("\nNajveći dužnik je... \n");

            String sql = "DROP DATABASE IF EXISTS [UnosPrijatelja]; CREATE DATABASE [UnosPrijatelja]";
            using (SqlCommand command = new SqlCommand(sql, cnn))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("\nNapravili smo novu bazu za 'UnosPrijatelja'.\n");

            }


            Console.WriteLine("\n------------------------------------------------------------------------------");
            cnn.Close();
            Console.WriteLine("Veza je zatvorena!\n");
            Console.WriteLine("------------------------------------------------------------------------------\n");
        }
    }
}
