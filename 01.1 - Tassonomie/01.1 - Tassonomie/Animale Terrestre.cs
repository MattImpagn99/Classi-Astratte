using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._1___Tassonomie
{
    abstract class  Animale_Terrestre : Animale
    {
       public Animale_Terrestre(string Nome, int NumeroZampe,  string SiMuove) : base (Nome,NumeroZampe, "Animale Terrestre","Terra", SiMuove)
       {

       }
    }
}
