using System;

namespace _07_LancoltLista
{
    public class Program
    {
        public static void BerakasKiiro(string tartalom)
        {
            Console.WriteLine("Beraktam a " + tartalom+ " host");
        }
        public static void MiVanAListaban(string tartalom)
        {
            Console.WriteLine("Ez van benne van a listában : " + tartalom);
        }
        static void Main(string[] args)
        {
            LancoltLista list = new LancoltLista();
            SzuperHos a = new SzuperHos("a", false, 2, 3, Oldal.gonosz);
            SzuperHos b = new SzuperHos("b", false, 4, 3, Oldal.gonosz);
            SzuperHos c = new SzuperHos("c", false, 1, 3, Oldal.gonosz);
            SzuperHos d = new SzuperHos("m", true, 11, 11, Oldal.gonosz);
            try
            {
                list.HozzaAdas(a, BerakasKiiro);
                list.HozzaAdas(b, BerakasKiiro);
                list.HozzaAdas(c, BerakasKiiro);
                list.HozzaAdas(d, BerakasKiiro);
            }catch(AlreadyInListException e)
            {
                Console.WriteLine("Ez a hos mar a listaban van: " + e.Message);
            }

            Console.WriteLine("keressek egy host nev szerint ? (i igen n nem)");
            if(Console.ReadLine() == "i")
            {
                Console.WriteLine("Kerek egy nevet ");
                try { list.NevKereses(Console.ReadLine()); }catch(ItsNotInTheList)
                {
                    Console.WriteLine("Nincs ilyen nevu hos");
                }
            }
            Console.WriteLine("Toroljek egy host nev alapjan ?(i igen n nem)");
            if(Console.ReadLine() == "i")
            {
                Console.WriteLine("Kerek egy nevet");
                list.ElemTorles(Console.ReadLine());
            }

            LancoltLista szurtlista = list.Szures(list);
            szurtlista.ListaElemeiKiiro(szurtlista, MiVanAListaban);
            Console.ReadLine();
        }
    }
}
