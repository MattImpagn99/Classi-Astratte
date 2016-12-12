using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
   public abstract class Mammifero_Fluviale:Animale_Terrestre
    {
        public Mammifero_Fluviale(string Nome,string mManto):base(Nome,4,"cammina/nuota",mManto)
        {

        }
    }
}
