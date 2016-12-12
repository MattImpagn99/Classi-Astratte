using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    class Pinguino:Uccello_Marino,Animale_Piumoso
    {
        public Pinguino():base("pinguino",2)
        {

        }
        public void DescrizionePiume()
        {
            Console.WriteLine("Le sue piume sono affascinanti.");
        }
    }
}
