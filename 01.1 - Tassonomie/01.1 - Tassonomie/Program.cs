using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1___Tassonomie
{
    class Program
    {
        static void Main(string[] args)
        {
            Uomo n = new Uomo();
            n.Riepilogo();
            Console.WriteLine("---------------------------------");

            Tonno t = new Tonno();
            t.Riepilogo();
            Console.WriteLine("---------------------------------");

            Salmone s = new Salmone();
            s.Riepilogo();
            Console.WriteLine("---------------------------------");

            Pinguino p = new Pinguino();
            p.Riepilogo();
            Console.WriteLine("---------------------------------");

            Pesce pe = new Pesce();
            pe.Riepilogo();
            Console.WriteLine("---------------------------------");

            Corvo c = new Corvo();
            c.Riepilogo();
            Console.WriteLine("---------------------------------");

            Cavallo ca = new Cavallo();
            ca.Riepilogo();
            Console.WriteLine("---------------------------------");

            Console.ReadLine();
        }
    }
}
