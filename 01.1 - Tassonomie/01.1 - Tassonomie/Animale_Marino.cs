using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1___Tassonomie
{
    abstract class Animale_Marino:Animale
    {
        public Animale_Marino(string Nome):base (Nome,0,"Animale Marino", "Mare-Oceano","Nuota")
        {

        }
    }
}
