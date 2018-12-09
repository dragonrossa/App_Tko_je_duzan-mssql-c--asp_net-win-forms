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
    public partial class ProgramSix : Prijatelj
    {

        static public void Six()
        {

            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.WriteLine("KALKULACIJA TROŠKOVA");
            Console.WriteLine("Provjerite tko je najmanje i najviše dužan.");
            Console.WriteLine("Provjerite ukupan dug vaših prijatelja.");
            int izbor2 = 0;
            Console.WriteLine("1 - ispis najvećeg dužnika");
            Console.WriteLine("2 - ispis najmanjeg dužnika");
            Console.WriteLine("3 - ispis ukupnog duga");
            Console.WriteLine("\n------------------------------------------------------------------------------");
            Console.Write("Upišite vaš izbor: ");
            izbor2 = int.Parse(Console.ReadLine());



            if (izbor2 == 1)
            {

                //ispis najvećeg dužnika


                string query = "SELECT TOP 1 * from Prijatelji WHERE IznosPicaKn = (SELECT MAX(IznosPicaKn) from Prijatelji)";
                string connectionSql = "SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;";
                StreamWriter myFile = new StreamWriter(@"UnosPrijatelja_max.txt");

                using (SqlConnection connection = new SqlConnection(connectionSql))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            myFile.WriteLine(String.Format("Najveći dužnik ima ID{0}.\nNjegovo/njezino ime je {1} {2} iz {3}, {4} te ste zajedno popili piće na {5}.\nPopili ste {6} za {7} kn.\nVrijeme je da obnovite vaše prijateljstvo.",
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


                //ispisujemo iz txt UnosPrijatelja_max

                StreamReader maxDug = new StreamReader("UnosPrijatelja_max.txt");
                string ispisDug = maxDug.ReadToEnd();
                Console.WriteLine("\n------------------------------------------------------------------------------");
                Console.WriteLine(ispisDug);
                Console.WriteLine("------------------------------------------------------------------------------\n");


            }

            //-----------------------------------------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------------------------//


            else if (izbor2 == 2)
            {

                //Najmanji dug, upis iz baze u txt te ispis

                string query2 = "select TOP 1 * from [Prijatelji] where IznosPicaKn = (select min(IznosPicaKn) from Prijatelji)";
                string connectionSql2 = "SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;";
                StreamWriter myFile2 = new StreamWriter(@"UnosPrijatelja_min.txt");

                using (SqlConnection connection = new SqlConnection(connectionSql2))
                {
                    SqlCommand command = new SqlCommand(query2, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            myFile2.WriteLine(String.Format("Najmanji dužnik ima ID{0}.\nNjegovo/njezino ime je {1} {2} iz {3}, {4} te ste zajedno popili piće na {5}.\nPopili ste {6} za {7} kn.\nVrijeme je da obnovite vaše prijateljstvo.",
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
                        myFile2.Close();
                    }
                }



                //ispisujemo iz txt UnosPrijatelja_max


                StreamReader minDug = new StreamReader("UnosPrijatelja_min.txt");
                string ispisDugMin = minDug.ReadToEnd();
                Console.WriteLine("\n------------------------------------------------------------------------------");
                Console.WriteLine(ispisDugMin);
                Console.WriteLine("------------------------------------------------------------------------------\n");


            }
            //-----------------------------------------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------------------------//
            //-----------------------------------------------------------------------------------------------------------//


            //ukupan dug


            else if (izbor2 == 3)
            {
                string query4 = "SELECT SUM(IznosPicaKn) as 'Ukupni dug u kn' from Prijatelji; ";
                string connectionSql3 = "SERVER=.\\SQLEXPRESS;Database=UnosPrijatelja;Integrated Security=true;";
                StreamWriter myFile3 = new StreamWriter(@"UnosPrijatelja_UK.txt");

                using (SqlConnection connection = new SqlConnection(connectionSql3))
                {
                    SqlCommand command = new SqlCommand(query4, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            myFile3.WriteLine(String.Format("Prijatelji su vam ukupno dužni {0} kn. Bilo bi vrijeme da se podružite!", reader["Ukupni dug u kn"]));
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);

                    }
                    finally
                    {
                        reader.Close();
                        myFile3.Close();
                    }
                }



                //ispisujemo iz txt UnosPrijatelja_max

                StreamReader ukDug = new StreamReader("UnosPrijatelja_UK.txt");
                string ispisDugUk = ukDug.ReadToEnd();
                Console.WriteLine("\n------------------------------------------------------------------------------");
                Console.WriteLine(ispisDugUk);
                Console.WriteLine("------------------------------------------------------------------------------\n");


            }
        }
    }
}
