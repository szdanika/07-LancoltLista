using System;

namespace _07_LancoltLista
{
    public class Program
    {
        public static void kiiro(string tartalom)
        {
            Console.WriteLine("Beraktam a " + tartalom+ " host");
        }
        static void Main(string[] args)
        {
            LancoltLista list = new LancoltLista();
            SzuperHos a = new SzuperHos("a", false, 2, 3, Oldal.gonosz);
            SzuperHos b = new SzuperHos("b", false, 4, 3, Oldal.gonosz);
            SzuperHos c = new SzuperHos("c", false, 1, 3, Oldal.gonosz);
            SzuperHos d = new SzuperHos("c", false, 1, 3, Oldal.gonosz);
            try
            {
                list.HozzaAdas(a, kiiro);
                list.HozzaAdas(b, kiiro);
                list.HozzaAdas(c, kiiro);
                list.HozzaAdas(d, kiiro);
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
            Console.ReadLine();
        }
    }
}
