using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    class Pesce:Animale_Marino,Animale_Squamoso
    {
        public Pesce(string Nome,string mManto):base(Nome,0,"mare",mManto)
        {

        }
        public void DescrizioneSquame()
        {
            Console.WriteLine("Le sue squame sono gialle.");
        }
    }
}
