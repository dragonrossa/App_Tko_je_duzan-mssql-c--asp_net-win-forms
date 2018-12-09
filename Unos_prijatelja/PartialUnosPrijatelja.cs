using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Unos_prijatelja
{
    public partial class Prijatelj
    {
        // deklaracija klase Prijatelj s popratnim svojstvima, metodama i događajima

        private static int indeks;
        private string ime;
        private string prezime;
        private string adresa;
        private int postanski_broj;
        private string mjesto_sastanka;
        private int broj_mobitela;
        private DateTime datum_sastanka;
        private string pice;
        private double iznos_pica;
        private DateTime starost;



        public int Indeks
            {
                get
                {
                    indeks = Interlocked.Increment(ref indeks);
                    return indeks;

                }

                set
                {

                    indeks = value;

                }

            }



            public string Ime
            {
                get { return ime; }
                set { ime = value; }
            }

            public string Prezime
            {
                get { return prezime; }
                set { prezime = value; }
            }

            public string Adresa
            {
                get { return adresa; }
                set { adresa = value; }
            }

            public int PostanskiBroj
            {
                get { return postanski_broj; }
                set { postanski_broj = value; }
            }

            public int BrojMobitela
            {
                get { return broj_mobitela; }
                set { broj_mobitela = value; }
            }


            public string MjestoSastanka
            {
                get { return mjesto_sastanka; }
                set { mjesto_sastanka = value; }
            }

            public DateTime DatumSastanka
            {
                get { return datum_sastanka; }
                set { datum_sastanka = value; }
            }

            public string Pice
            {
                get { return pice; }
                set { pice = value; }
            }

            public double IznosPicaKn
            {
                get { return iznos_pica; }
                set { iznos_pica = value; }
            }



            public TimeSpan Razlika()
            {

                starost = DateTime.Now;
                TimeSpan razlika = starost.Subtract(datum_sastanka);
                return razlika;


            }


       


    }
}
