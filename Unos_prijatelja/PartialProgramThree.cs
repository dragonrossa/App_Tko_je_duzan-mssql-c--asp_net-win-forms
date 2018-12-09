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
    public partial class ProgramThree : Prijatelj
    {
        static public void Three ()
        {

            //promjena vrijednosti - UPDATE ID-ovog imena i prezimena u bazu


            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("\nVeza je otvorena!");



            string ID;
            string ime;
            string prezime;

            SqlConnection con;

            con = new SqlConnection("SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;");
            Console.WriteLine();




            SqlCommand sqlCommand = new SqlCommand("UPDATE Prijatelji SET Ime = @ime, Prezime=@prezime Where indeks = @add", con);

            Console.WriteLine("\nUnesite ID za kojeg želite napraviti promjenu imena i prezimea:");
            sqlCommand.Parameters.AddWithValue("@add", ID = Console.ReadLine());
            Console.WriteLine("\nUnesite ime zamjene:");
            sqlCommand.Parameters.AddWithValue("@ime", ime = Console.ReadLine());
            Console.WriteLine("\nUnesite prezime zamjene:");
            sqlCommand.Parameters.AddWithValue("@prezime", prezime = Console.ReadLine());


            try
            {


                con.Open();
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Uspješno izvršena zamjena!");



                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //zapis promjene u txt file

            Console.WriteLine("Zapisujem promjenu u [UnosPrijatelja.txt]");

            string query = "SELECT * FROM [Prijatelji]";
            string connectionSql = "SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;";
            StreamWriter myFile = new StreamWriter(@"UnosPrijatelja.txt");

            using (SqlConnection connection = new SqlConnection(connectionSql))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        myFile.WriteLine(String.Format("{0} {1} {2}  {3}  {4}  {5}  {6}  {7}",
                        reader["Indeks"], reader["Ime"], reader["Prezime"], reader["Adresa"], reader["PostanskiBroj"], reader["MjestoSastanka"], reader["Pice"], reader["IznosPicaKN"]));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);

                }
                finally
                {
                    reader.Close();
                    myFile.Close();
                }
            }
        }
    }
}
