using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    public abstract class Mammifero_Terrestre:Animale_Terrestre
    {
        public Mammifero_Terrestre(string Nome,int nZampe,string mSiMuove,string mManto):base(Nome,nZampe,mSiMuove,mManto)
        {

        }
    }
}
