using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bármi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nevek = new string[] { "János","Ádám","György","Éva","Enikő"};

            //List<string> iBetusok = new List<string>();
            //foreach (var nev in nevek)
            //{
            //    if (nev.Contains("i"))
            //    {
            //        iBetusok.Add(nev);
            //    }
            //}

            var iBetusok = from nev in nevek where nev.Contains('i') select nev;

            Console.WriteLine("A nevek amelyek tartalmazzák az i betűt:");
            foreach (var i in iBetusok)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
