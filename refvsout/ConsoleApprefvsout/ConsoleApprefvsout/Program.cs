using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApprefvsout
{
    class Program
    {
        /// <summary>
        /// 1. out i ref sa slowami kluczowymi w c# ktore pomagaja przekazac referencje
        /// 2. ref przekazuje wartosc i referencje (dziala dwustronnie)
        /// 3. out przekazuje referencje ale nie wartosci (dziala jednostronnie)
        /// </summary>
        /// 
        static int outsideInt = 20;

        static void Main(string[] args)
        {
            int outsideInt = 20;
            SomeMethod(out outsideInt);

            Console.WriteLine(outsideInt);
            Console.ReadKey();
        }

        private static void SomeMethod(out int insideInt)
        {
            insideInt = 0;
            insideInt = insideInt + 10;
        }
    }
}


