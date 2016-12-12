using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    class Ippopotamo:Mammifero_Fluviale,Quadrupede
    {
        public Ippopotamo():base("ippopotamo","ruvido")
        {

        }
        public void DescrizioneZampe()
        {
            Console.WriteLine("Sono fiero di avere quattro zampe");
        }
    }
}
