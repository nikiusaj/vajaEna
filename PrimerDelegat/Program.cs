using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDelegat
{
    class Program
    {
        //1.definiraj delegat
      //  public delegate bool FunkcijaZaNize(string s);
        //2.napisi metodo ki sprejme nize in delegata za parametre
        public static List<string> DelajOperacijeNadNizi(string[] a, Func<string,bool> mojaFunkcija) {
            List<string> rezultat = new List<string>();
            foreach (var s in a)
            {
                if (mojaFunkcija(s)) 
                {
                    rezultat.Add(s);
                }
            }


            return rezultat;
        } 

        //3
        public static bool ZacneZA(string s) { 
        return s.StartsWith("A");
        }

        static void Main(string[] args)
        {
           // FunkcijaZaNize an = delegate (string s){ return s.StartsWith("A");};
            string[] mojiNizi = { "Adam", "Alan", "Bob", "Steve", "Jim", "Aiden" };
            List<string> Aji = DelajOperacijeNadNizi(mojiNizi, ZacneZA);
            List<string> Nji = DelajOperacijeNadNizi(mojiNizi, delegate (string s) { return s.EndsWith("n"); });
            List<string> Bji = DelajOperacijeNadNizi(mojiNizi, s=>s.StartsWith("B"));
            foreach (var x in Bji) {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }



     
    }



}
