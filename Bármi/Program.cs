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

            int[] szamok = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var szamokNagyobb = from szam in szamok where szam > 5 select szam;
            Console.WriteLine("A nevek amelyek tartalmazzák az i betűt:");
            foreach (var i in iBetusok)
            {
                Console.WriteLine(i);
            }
            Console.Write("Számok amelyek nagyobbak 5-nél: ");
            foreach (var i in szamokNagyobb)
            {
                Console.Write(i+ " ");
            }

            Console.ReadKey();
        }
    }
}
