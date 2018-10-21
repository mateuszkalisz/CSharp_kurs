using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrukcje_warunkowe
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ile masz lat: ");
            int age = int.Parse(Console.ReadLine());
            if (age > 30) Method1();
            else if (age >= 18) Method2();
            else Method3();

            string text = age >= 18 ? "Jestes pelnoletni" : "Jestes gowniarzem!";
            Console.WriteLine(text);

            Console.ReadKey();
        }

        static void Method1()
        {
            Console.WriteLine("Jesteś stary");
        }

        static void Method2()
        {
            Console.WriteLine("Jesteś młody, ale jesteś pełnoletni ;)");

        }

        static void Method3()
        {
            Console.WriteLine("Jesteś dzieciakiem!");
        }
    }

}
