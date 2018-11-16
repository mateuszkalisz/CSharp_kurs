using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Toys newToy = new Toys();
            newToy.AddToys(CallBackToysMethod);

        }

        static void CallBackToysMethod(int i)
        {
            Console.WriteLine("nowa zabawka nr: " + (i + 1));
        }

    }

    public class Toys
    {
        public delegate void CallBackToysDelegate(int i);

        Dictionary<int, string> KindOfToys = new Dictionary<int, string>();
                        
        public void AddToys(CallBackToysDelegate obj)
        {
            Console.WriteLine("Witamy nową zabawkę!");

            for (int i = 1; i < 10; i++)
            {
                KindOfToys.Add(i, "nowa zabawka" + (i+1));
                obj(i);
            }

            Console.WriteLine("Dictionary nr 1: " + KindOfToys[1]);

            Console.ReadKey();

        }

    }

}
