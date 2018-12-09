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
   public partial class ProgramOne : Prijatelj
    {

        static public void One ()
        {

            Prijatelj prijatelj = new Prijatelj();

            int izbor2 = 0;

            do
            {


                //FileStream fs1 = new FileStream("UnosPrijatelja.txt", FileMode.Append, FileAccess.Write);
                //TextWriter sw = new StreamWriter(fs1);

                SqlConnection openCon;

                openCon = new SqlConnection("SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;");



                Console.WriteLine("\n------------------------------------------------------------------------------");

                Console.WriteLine("\nVeza je otvorena!");

                string saveStaff = "SET IDENTITY_INSERT [Prijatelji] ON; INSERT into Prijatelji(Indeks,Ime,Prezime,Adresa,PostanskiBroj,MjestoSastanka,Pice, IznosPicaKN)" +
                    "VALUES (@Indeks, @Ime, @Prezime, @Adresa, @PostanskiBroj, @MjestoSastanka, @Pice, @IznosPicaKN)";



                SqlCommand querySaveStaff = new SqlCommand(saveStaff);

                querySaveStaff.Connection = openCon;
                querySaveStaff.Parameters.Add("@Indeks", SqlDbType.Int).Value = prijatelj.Indeks;




                //unos imena prijatelja

                try
                {



                    Console.WriteLine("\nUnesi ime prijatelja: ");


                    querySaveStaff.Parameters.Add("@Ime", SqlDbType.VarChar, 50).Value = prijatelj.Ime = Console.ReadLine();


                }
                catch (Exception ex)
                {

                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }




                //unos prezimena prijatelja

                try
                {
                    Console.WriteLine("\nUnesi prezime prijatelja: ");

                    querySaveStaff.Parameters.Add("@Prezime", SqlDbType.VarChar, 50).Value = prijatelj.Prezime = Console.ReadLine();


                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;

                }


                //unos adrese prijatelja

                try
                {
                    Console.WriteLine("\nUnesi adresu prijatelja: ");

                    querySaveStaff.Parameters.Add("@Adresa", SqlDbType.VarChar, 100).Value = prijatelj.Adresa = Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }


                //unos postanoskog broja prijatelja

                try
                {
                    Console.WriteLine("\nUnesi postanski broj prijatelja: ");

                    querySaveStaff.Parameters.Add("@PostanskiBroj", SqlDbType.Int).Value = prijatelj.PostanskiBroj = int.Parse(Console.ReadLine());


                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;

                }

                //unos mjesta sastanka

                try
                {

                    Console.WriteLine("\nUnesi mjesto sastanka: ");

                    querySaveStaff.Parameters.Add("@MjestoSastanka", SqlDbType.VarChar, 50).Value = prijatelj.MjestoSastanka = Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }


                //unos broja mobitela prijatelja

                try
                {
                    Console.WriteLine("\nUpiši broj mobitela prijatelja:");
                    prijatelj.PostanskiBroj = int.Parse(Console.ReadLine());


                }
                catch (Exception ex)
                {

                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }


                //unos datuma sastanka

                try
                {
                    Console.WriteLine("\nUnesi datum sastanka: ");
                    prijatelj.DatumSastanka = DateTime.Parse(Console.ReadLine());

                    DateTime datumsastanka = prijatelj.DatumSastanka;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }


                //unos pića kojeg ste popili s prijateljem

                try
                {
                    Console.WriteLine("\nUnesi piće koje ste popili: ");

                    querySaveStaff.Parameters.Add("@Pice", SqlDbType.VarChar, 50).Value = prijatelj.Pice = Console.ReadLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }


                //unos iznosa pića

                try
                {
                    Console.WriteLine("\nUnesi iznos pića koje ste popili (u kn): ");

                    querySaveStaff.Parameters.Add("@IznosPicaKN", SqlDbType.Int).Value = prijatelj.IznosPicaKn = int.Parse(Console.ReadLine());


                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }





                openCon.Open();

                querySaveStaff.ExecuteNonQuery();
                Console.WriteLine("Upisano u tablicu [Prijatelji].");
                openCon.Close();




                //upit za upis novog prijatelja




                try
                {
                    Console.WriteLine("\nUpisali ste novog prijatelja!");

                    Console.WriteLine("\nŽeliš li upisati novog prijatelja?");
                    Console.WriteLine("\n1 - Da");
                    Console.WriteLine("\n2 - Ne");
                }
                catch (Exception ex)
                {

                    Console.WriteLine("\nDogodila se greška!");
                    Console.WriteLine("\nOpis greške" + ex.Message);
                    throw;
                }


                izbor2 = int.Parse(Console.ReadLine());





                //sw.WriteLine("ID" + (prijatelj.Indeks - 1) + " " +
                //             prijatelj.Ime + " " +
                //             prijatelj.Prezime + " " +
                //             prijatelj.Adresa + " " +
                //             prijatelj.PostanskiBroj + " " +
                //             prijatelj.MjestoSastanka + " " +
                //             prijatelj.Razlika() + " " +
                //             prijatelj.Pice + " "
                //             + prijatelj.IznosPicaKn);




                //sw.Flush();
                //sw.Close();
                //fs1.Close();




            } while (izbor2 == 1);


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





            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine("Vaš prijatelj je upisan!");
            Console.WriteLine("------------------------------------------------------------------------------\n");




            StreamReader ulaz0 = new StreamReader("UnosPrijatelja.txt");
            string tekst0 = ulaz0.ReadToEnd();
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine(tekst0);
            Console.WriteLine("------------------------------------------------------------------------------\n");




        }




    }
}
