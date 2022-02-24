using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfejsi
{
    internal abstract class Osoba
    {
        internal abstract void Nebitno();
    }

    internal class Student : Osoba, IIspis
    {
        internal override void Nebitno()
        {
            throw new NotImplementedException();
        }

        void IIspis.Ispis()
        {
            Console.WriteLine("Ovo je student");
        }
    }

    internal class Radnik : Osoba, IIspis
    {
        internal override void Nebitno()
        {
            throw new NotImplementedException();
        }

        void IIspis.Ispis()
        {
            Console.WriteLine("Ovo je radnik");
        }
    }
}