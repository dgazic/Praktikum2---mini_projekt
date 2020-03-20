using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Projekt1
{

    public class Tvrtka
    {
        public Tvrtka()
        {
            Naziv_tvrtke = "Infobip";
            Raspolozivi_radnici = 1000;
        }
        public string Naziv_tvrtke;
        private float Raspolozivi_radnici;
        public void nazivtvrtke()
        {
            Console.WriteLine("Tvrtka : " + Naziv_tvrtke);
        }
        public void zaposljavanje(int iznos)
        {
            Raspolozivi_radnici += iznos;
        }
        public void otpust(int iznos)
        {
            Raspolozivi_radnici -= iznos;
        }


    }
    public class Radnik : Tvrtka
    {
        public int radni_staz;
        public string ime_radnika;
        public string prezime_radnika;
        public string email;
        public string odijel;

        public void dodaj_radnika(string radnik)
        {

            
        }
       




    }
    class Program
    {
        static void Main(string[] args)
        {
            Radnik NoviRadnik = new Radnik();

            try
            {
            

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }

    }
}