using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tassonomia_e_Interfaccie
{
    public abstract class Animale_Marino:Animale
    {
        public Animale_Marino(string Nome, int mNumeroZampe,string mHabitat,string mManto):base(Nome, mNumeroZampe,"animale marino",mHabitat,"nuota",mManto)
        {

        }
    }
}
