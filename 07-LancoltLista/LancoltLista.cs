using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LancoltLista
{
    public delegate void KiirasHandler(string tartalom);
    public class ListaElem
    {
        public ListaElem kov;
        public SzuperHos tart;
    }
    public class LancoltLista
    {
        ListaElem fej = new ListaElem();
        ListaElem e;
        public void HozzaAdas(SzuperHos tartalom, KiirasHandler kh)
        {
            KiirasHandler _kh = kh;
            ListaElem p = fej;
            ListaElem uj = new ListaElem();
            uj.tart = tartalom;
            int i = 0;
            bool beraktam = false;
            if (p.kov == null)
            {
                fej.kov = uj;
                _kh?.Invoke(uj.tart.Nev);
            }
            else
            {
                while (p.kov != null && beraktam != true)
                {
                    i++;
                    e = p;
                    p = p.kov;
                    AlreadyInList(tartalom);
                    if (p.tart.Ero > uj.tart.Ero)
                    {
                        e.kov = uj;
                        uj.kov = p;
                        beraktam = true;
                        _kh?.Invoke(uj.tart.Nev);
                    }
                    
                }
                if(p.kov == null && beraktam != true)
                {
                    p.kov = uj;
                    _kh?.Invoke(uj.tart.Nev);
                }
            }
        }
        public void AlreadyInList(SzuperHos t)
        {
            ListaElem p = fej;
            while(p.kov != null)
            {
                p = p.kov;
                if (p.tart.Nev == t.Nev)
                {
                    throw new AlreadyInListException(t.Nev);
                }
            }

        }
        public bool ItsTheSame(SzuperHos a, SzuperHos b)
        {
            return (a.Nev == b.Nev && a.Mutans == b.Mutans && a.Old == b.Old && a.Ero == b.Ero);
        }
        public void NevKereses(string nev)
        {
            ListaElem p = fej;
            bool volt = false;
            while (p.kov != null)
            {
                p = p.kov;
                if (p.tart.Nev == nev)
                {
                    volt = true;
                }
            }
            if (volt == false)
                throw new ItsNotInTheList();
            else
                Console.WriteLine("Van ilyen hos");
        }
        public void ElemTorles(string nev)
        {
            ListaElem p = fej;
            ListaElem elozo;
            while (p.kov != null)
            {
                elozo = p;
                p = p.kov;
                if (p.tart.Nev == nev)
                {
                    elozo.kov = p.kov;
                }
            }
        }
        public void ElemTorles(SzuperHos hos)
        {
            ListaElem p = fej;
            ListaElem elozo;
            while (p.kov != null)
            {
                elozo = p;
                p = p.kov;
                if (ItsTheSame(p.tart, hos))
                {
                    elozo.kov = p.kov;
                }
            }
        }
        public LancoltLista Szures(LancoltLista lista)
        {
            LancoltLista vegeredmeny = new LancoltLista();
            ListaElem p = lista.fej;
            ListaElem vegnezo = new ListaElem();
            while(p.kov != null)
            {
                p = p.kov;
                if(p.tart.Mutans == true && p.tart.Ero > 10)
                {
                    if (vegeredmeny.fej.kov == null)
                    {
                        vegeredmeny.fej.kov = p.kov;
                        vegnezo = vegeredmeny.fej.kov;
                    }
                    else
                    {
                        vegnezo.kov = p;
                        vegnezo = vegnezo.kov;
                        vegnezo.kov = null;
                    }
                }
            }
            return vegeredmeny;
        }
        public void ListaElemeiKiiro(LancoltLista lista, KiirasHandler kh)
        {
            KiirasHandler _kh = kh;
            ListaElem p = lista.fej;
            while(p.kov != null)
            {
                p = p.kov; Console.WriteLine("a");
                _kh?.Invoke(p.tart.Nev);
            }
        }
    }
}
