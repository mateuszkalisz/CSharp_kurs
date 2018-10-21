using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegaty
{
    class Program
    {
        public delegate void delegatablabla();

        static void Main(string[] args)
        {
            delegatablabla blabla = SomeMessage;
            blabla.Invoke();

        }

        static void SomeMessage()
        {
            Console.WriteLine("blablabla");
            Console.ReadKey();
        }

    }
}
