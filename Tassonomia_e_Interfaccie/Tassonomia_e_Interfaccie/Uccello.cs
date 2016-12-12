using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    public abstract class Uccello:Animale_Terrestre,Animale_Piumoso
    {
        public Uccello(string Nome):base(Nome,2,"vola","piume")
        {

        }
        public void DescrizionePiume()
        {
            Console.WriteLine("Le sue piume sono affascinanti.");
        }
    }
}
