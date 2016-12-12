using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1___Tassonomie
{
     abstract class Uccello:Animale_Terrestre
    {
        public Uccello(string Nome) : base (Nome, 2 , "cammina/vola")
        {

        }

    }
}
