using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1___Tassonomie
{
    abstract class Animale_Fluviale:Animale
    {
        public  Animale_Fluviale(string Nome):base (Nome,0,"Animale Fluviale", "Fiume/Mare","Nuota")
        {

        }
    }
}
