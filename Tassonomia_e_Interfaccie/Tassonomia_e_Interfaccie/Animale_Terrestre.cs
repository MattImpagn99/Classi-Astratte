using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    public abstract class Animale_Terrestre : Animale
    {
        public Animale_Terrestre(string Nome, int mNumeroZampe,string mSiMuove, string mManto):base(Nome,mNumeroZampe,"animale terrestre","terra",mSiMuove,mManto)
        {

        }
    }
}
