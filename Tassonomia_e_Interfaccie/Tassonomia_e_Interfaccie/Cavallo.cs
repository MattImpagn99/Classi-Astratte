using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    class Cavallo:Mammifero_Terrestre,Quadrupede,Animale_Peloso
    {
        public Cavallo():base("cavallo",4,"trotta/galoppa","peloso")
        {

        }
        public void DescrizioneZampe()
        {
            Console.WriteLine("Sono fiero di avere quattro zampe,tra l'altro,corro velocissimo.");
        }
        public void Pelo()
        {
            Console.WriteLine("Il mio manto può essere maculato.");
        }
    }
}
