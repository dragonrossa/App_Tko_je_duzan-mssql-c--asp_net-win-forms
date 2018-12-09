using System;

namespace Unos_prijatelja
{
  
    public partial class Prijatelj
    {
       
        //Partial klasa koja služi za deklaraciju svojstva, metoda i događaja


    }


    public partial class ProgramOne : Prijatelj
    {
        //if izbor 1
    }

    public partial class ProgramTwo : Prijatelj
    {
        // if izbor 2
    }


    public partial class ProgramThree : Prijatelj
    {
        // if izbor 3
    }

    public partial class ProgramFour : Prijatelj
    {
        //if izbor 4
    }

    public partial class ProgramFive : Prijatelj
    {
        //if izbor 5
    }
    public partial class ProgramSix : Prijatelj
    {
        //if izbor 6
    }

    public partial class ProgramSeven : Prijatelj
    {
        //if izbor 7
    }

    public partial class ProgramEight : Prijatelj
    {
        //if izbor 8
    }

    public partial class ProgramTen
    {
        //if izbor 10
    }


    public partial class Program
    {
        static void Main(string[] args)
        {


            // Pozdravna poruka za nove korisnike aplikacije

            Console.WriteLine("\n------------------------------TKO JE DUŽAN------------------------------------");
            Console.WriteLine("\nOva aplikacija omogućuje olakšno praćenje potrošnje tvojih tekućih troškova.\n");
            Console.WriteLine("Prati koliko si u dugovanju te tko je sljedeći tko mora platiti cugu.\n");
            Console.WriteLine("Čuvaj sve svoje prijatelje na jednom mjestu uz pomoć ove aplikacije.\n");
            Console.WriteLine("Kontaktiraj prijatelja ukoliko se niste već neki duži period vidjeli/čuli.\n");
            Console.WriteLine("Prema raznim prijedlozima posjetite nove caffe barove ili restorane.\n");
            Console.WriteLine("Napravite promjenu kako bi vaše prijateljstvo duže trajalo.\n");
            Console.WriteLine("------------------------------------------------------------------------------\n");


            Console.WriteLine("-----------------------------------Izbornik-----------------------------------\n");

            Console.WriteLine("1. Unos novog prijatelja u bazu i listu (INSERT)\n");
            Console.WriteLine("2. Ispis iz liste svih prijatelja (SELECT/READ) \n");
            Console.WriteLine("3. Promjena informacija o prijatelju (UPDATE) \n");
            Console.WriteLine("4. Izbrišite prijatelja (DELETE) \n");
            Console.WriteLine("5. Izbrišite cijelu listu (DELETE) \n");
            Console.WriteLine("6. Sortiranje po dugu (MAX, MIN, SUM) \n");
            Console.WriteLine("7. Izrada nove baze (CREATE) \n");
            Console.WriteLine("8. Izrada nove tablice/brisanje tablice (CREATE)\n");
            Console.WriteLine("9.----------------------------\n");
            Console.WriteLine("10. Izlaz iz aplikacije (EXIT) \n");
            Console.WriteLine("Upišite svoj izbor:\n");


            bool T = true;

            do
            {

            int izbor = 0;

            Console.WriteLine("-----------------------------------Izbornik-----------------------------------\n");

            Console.WriteLine("1. Unos novog prijatelja u bazu i listu (INSERT)\n");
            Console.WriteLine("2. Ispis iz liste svih prijatelja (SELECT/READ) \n");
            Console.WriteLine("3. Promjena informacija o prijatelju (UPDATE) \n");
            Console.WriteLine("4. Izbrišite prijatelja (DELETE) \n");
            Console.WriteLine("5. Izbrišite cijelu listu (DELETE) \n");
            Console.WriteLine("6. Sortiranje po dugu (MAX, MIN, SUM) \n");
            Console.WriteLine("7. Izrada nove baze (CREATE) \n");
            Console.WriteLine("8. Izrada nove tablice/brisanje tablice (CREATE)\n");
            Console.WriteLine("9.----------------------------\n");
            Console.WriteLine("10. Izlaz iz aplikacije (EXIT) \n");
            Console.WriteLine("Upišite svoj izbor:\n");

            izbor = int.Parse(Console.ReadLine());



            if (izbor == 1)
                {

                    ProgramOne.One();
                }

                else if (izbor == 2)
                {

                ProgramTwo.Two();

                   

                }

                else if (izbor == 3)
                {

                ProgramThree.Three();


                }

                else if (izbor == 4)
                {

                ProgramFour.Four();
  

                }

                  else if (izbor == 5) {


                ProgramFive.Five();
                   

                }



             else if (izbor == 6)
                {

                ProgramSix.Six();
                  

                }

                else if (izbor == 7)
                {


                ProgramSeven.Seven();


                }

                else if (izbor == 8)
                {

                ProgramEight.Eight();

                 

                }

                else if (izbor == 9)
                {

                }

                else if (izbor == 10)
                {


                ProgramTen.Ten();

                }


            } while (T == true);


                //admin aplikacija - > klasičan unos, sve što je potrebno za unos prijatelja
                //upis u txt datoteku te ispis
                //upis u bazu podataka te ispis

            }
        }



}


