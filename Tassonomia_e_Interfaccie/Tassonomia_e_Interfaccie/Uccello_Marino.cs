using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    public abstract class Uccello_Marino:Animale_Marino
    {
        public Uccello_Marino(string Nome,int mNumZampe):base(Nome,mNumZampe,"antartide","piume")
        {

        }
    }
}
