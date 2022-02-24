using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    internal abstract class Figura
    {
        internal abstract int Povrsina();
    }

    internal class Kvadrat : Figura, IIspis
    {
        internal override int Povrsina()
        {
            return 123;
        }

        void IIspis.Ispis()
        {
            Console.WriteLine("Ovo je kvadrat");
        }
    }

    internal class Pravougaonik : Figura, IIspis
    {
        internal override int Povrsina()
        {
            return 123;
        }

        void IIspis.Ispis()
        {
            Console.WriteLine("Ovo je pravoguaonik");
        }
    }
}