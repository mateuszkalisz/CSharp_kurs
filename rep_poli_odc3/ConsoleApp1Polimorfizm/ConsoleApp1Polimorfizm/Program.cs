using System;

namespace ConsoleApp1Polimorfizm
{
    class Program
    {
        static void Main(string[] args)
        {
            Base base1 = new Base();
            base1.CreateBase("Basebody 11", 1.1f, 2.2f);

            MilitaryBase base2 = new MilitaryBase();
            base2.CreateBase("Militarybase 22", 9.9f, 10.10f, 100);

            Console.ReadKey();
        }
    }
}
