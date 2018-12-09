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
    public partial class ProgramEight : Prijatelj
    {
        static public void Eight()
        {


            SqlConnection cnn;

            cnn = new SqlConnection("SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;");

            cnn.Open();

            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("\nVeza je otvorena!");


            Console.WriteLine("Kreiramo tablicu Prijatelji...");
            String sql1 = "DROP TABLE IF EXISTS [Prijatelji];CREATE TABLE [Prijatelji] " +
                "(Indeks int PRIMARY KEY IDENTITY(1,1), Ime varchar(255) NOT NULL,Prezime varchar(255) NOT NULL, Adresa varchar(100) NOT NULL,PostanskiBroj int NOT NULL, MjestoSastanka varchar(50) NOT NULL, Pice varchar(50) NOT NULL, IznosPicaKn int NOT NULL, UNIQUE(Indeks));";

            using (SqlCommand command = new SqlCommand(sql1, cnn))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("\nNapravili smo novu tablicu 'Prijatelji'.\n");
                Console.WriteLine("Tablica je spremna za unos podataka. \n");

            }



            Console.WriteLine("\n------------------------------------------------------------------------------");
            cnn.Close();
            Console.WriteLine("Veza je zatvorena!\n");
            Console.WriteLine("------------------------------------------------------------------------------\n");
        }
    }
}
