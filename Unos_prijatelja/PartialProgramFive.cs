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
    public partial class ProgramFive : Prijatelj
    {

        static public void Five ()
        {

            //brišemo listu svih prijatelja

            Console.WriteLine("\nŽelite li izbrisati cijelu listu?");
            Console.WriteLine("\n1 - DA");
            Console.WriteLine("\n2 - NE");

            int brisi = 0;
            brisi = int.Parse(Console.ReadLine());


            if (brisi == 1)
            {
                FileInfo fi = new FileInfo("UnosPrijatelja.txt");
                FileStream fs = fi.Create();
                fs.Close();
                fi.Delete();
            }
            else
            {
                //break;

            }
        }
    }
}
