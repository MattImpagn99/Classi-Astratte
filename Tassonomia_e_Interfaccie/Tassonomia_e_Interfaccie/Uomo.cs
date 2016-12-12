using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    class Uomo:Mammifero_Terrestre,bipede,Animale_Peloso
    {
        public Uomo():base("uomo",2,"cammina/corre","derma")
        {

        }
        public void DescrizioneAbilità()
        {
            Console.WriteLine("Posso arrampicarmi facilmente.");
        }
        public void Pelo()
        {
            Console.WriteLine("Se non faccio attenzione assomiglierò a una scimmia.");
        }
    }
}
