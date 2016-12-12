using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    public abstract class Mammifero_Marino:Animale_Marino
    { 
        public Mammifero_Marino(string Nome):base(Nome,0,"oceano","squame")
        {

        }
    }
}
