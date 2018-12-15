using System;

namespace repOutRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int outsideValue = 20;
            SomeMethod(out outsideValue);

            Console.WriteLine(outsideValue);
            Console.ReadKey();

        }

        private static void SomeMethod(out int insideValue)
        {
            insideValue = 0;
            insideValue = insideValue + 10;
        }
    }
}

// ref - przekazuje i wartosc i referencje
// out - przekazuje tylko referencje
// brak - przekazuje tylko wartosc