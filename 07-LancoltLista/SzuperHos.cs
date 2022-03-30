using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LancoltLista
{
    enum Oldal { jo, gonosz, civil}
    internal class SzuperHos
    {
        public SzuperHos(string nev, bool mutans, int ero, int gyorsasag, Oldal old)
        {
            Nev = nev;
            Mutans = mutans;
            Ero = ero;
            Gyorsasag = gyorsasag;
            Old = old;
        }

        public string Nev { get; private set; }
        public bool Mutans { get; private set; }
        public int Ero { get; private set; }
        public int Gyorsasag { get; private set; }
        public Oldal Old { get; private set; }

    }
}
