using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1___Tassonomie
{
    abstract class Quadrupede:Animale_Terrestre
    {
        public Quadrupede(string Nome) : base (Nome, 4 , "nasce/cammina/corre")
        {

        }
    }
}
