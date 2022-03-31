using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_LancoltLista
{
    internal class AlreadyInListException : Exception
    {
        public AlreadyInListException(string m) : base(m)
        { }
    }
    public class ItsNotInTheList : Exception
    {
        public ItsNotInTheList()
        { }
    }
}
