using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1___Tassonomie
{
    abstract class Bipede:Animale_Terrestre
    {
        public Bipede(string Nome) : base (Nome, 2 , "cammina/nuota/corre/salta")
        {
            
        }

    }
}
