using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LancoltLista
{
    delegate void KiirasHandler(string tartalom);
    class ListaElem
    {
        public ListaElem kov;
        public SzuperHos tart;
    }
    internal class LancoltLista
    {
        ListaElem fej;
        ListaElem e;
        void HozzaAdas(SzuperHos tartalom, KiirasHandler kh)
        {
            KiirasHandler _kh = kh;
            ListaElem p = fej;
            ListaElem uj = new ListaElem();
            uj.tart = p;
            int i = 0;
        }
    }
}
