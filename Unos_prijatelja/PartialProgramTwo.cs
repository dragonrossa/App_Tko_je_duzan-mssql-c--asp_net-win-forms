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
   public partial class ProgramTwo : Prijatelj
    {
        static public void Two() 
        {


            //2. Ispis liste svih prijatelja iz txt filea

            Console.WriteLine("\n------------------------------------------------------------------------------\n");
            Console.WriteLine("Ispis iz liste prijatelja:");

            try
            {
                StreamReader ulaz = new StreamReader("UnosPrijatelja.txt");
                string tekst = ulaz.ReadToEnd();
                Console.WriteLine("\n------------------------------------------------------------------------------");
                Console.WriteLine(tekst);
                Console.WriteLine("------------------------------------------------------------------------------\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("\nNe mogu otvoriti datoteku!" + e.Message);

            }

            Console.ReadKey();

            Console.WriteLine("Ispis iz baze prijatelja:");




            SqlConnection openCon;

            openCon = new SqlConnection("SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;");
            openCon.Open();


            Console.WriteLine("\n------------------------------------------------------------------------------");




            string query = "SELECT * FROM [Prijatelji]";


            SqlCommand queryPrijatelji = new SqlCommand(query, openCon);

            using (SqlDataReader reader = queryPrijatelji.ExecuteReader())
            {
                while (reader.Read())
                {

                    Console.WriteLine(String.Format("{0} {1} {2}  {3}  {4}  {5}  {6}  {7}",
                       reader["Indeks"], reader["Ime"], reader["Prezime"], reader["Adresa"], reader["PostanskiBroj"], reader["MjestoSastanka"], reader["Pice"], reader["IznosPicaKN"]));

                }
            }




            queryPrijatelji.ExecuteNonQuery();

            openCon.Close();

            Console.WriteLine();

        }


    }
    
}
