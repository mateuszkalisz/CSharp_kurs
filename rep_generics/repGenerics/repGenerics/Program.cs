using System;

namespace repGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GenClass<string> CompString = new GenClass<string>();
            bool s = CompString.CompareTwoValues("blabla", "blabla");

            GenClass<int> CompInt = new GenClass<int>();
            bool i = CompInt.CompareTwoValues(1,2);

            GenClass<bool> CompBool = new GenClass<bool>();
            bool b = CompBool.CompareTwoValues(true,false);

            GenClass<char> CompChar= new GenClass<Char>();
            bool c = CompChar.CompareTwoValues('a', 'a');

            Console.WriteLine(s);
            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }

    class GenClass<AnyType>
    {
        public bool CompareTwoValues(AnyType x, AnyType y)
        {
            if (x.Equals(y))
                return true;
            else
                return false;
        }
    }
}
