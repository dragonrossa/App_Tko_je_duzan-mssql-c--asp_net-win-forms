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
    public partial class ProgramFour : Prijatelj
    {
        static public void Four()
        {

            //brišemo prijatelja po njegovom ID-u u bazi



            Console.WriteLine("\n------------------------------------------------------------------------------");

            Console.WriteLine("\nVeza je otvorena!");



            int IDa;






            SqlConnection con;

            con = new SqlConnection("SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;");
            Console.WriteLine();




            SqlCommand sqlCommand = new SqlCommand("DELETE from Prijatelji Where indeks = @add", con);

            Console.WriteLine("\nUnesite ID kojeg želite izbrisati iz liste/baze:");
            sqlCommand.Parameters.AddWithValue("@add", IDa = int.Parse(Console.ReadLine()));
            IDa = IDa - 1;


            try
            {


                con.Open();
                sqlCommand.ExecuteNonQuery();
                Console.WriteLine("Uspješno izbrisan korisnik!");



                con.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            //brišemo prijatelja po njegovom ID-u u listi



            var file = new List<string>(System.IO.File.ReadAllLines("UnosPrijatelja.txt"));
            file.RemoveAt(IDa);
            File.WriteAllLines("UnosPrijatelja.txt", file.ToArray());

            Console.WriteLine("Prijatelj je uspješno izbrisan!\n");



            Console.WriteLine("\nTrenutačna lista aktivnih prijatelja:\n");
            StreamReader ulaz3 = new StreamReader("UnosPrijatelja.txt");
            string tekst3 = ulaz3.ReadToEnd();
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine(tekst3);
            Console.WriteLine("------------------------------------------------------------------------------\n");
        }
    }
}
