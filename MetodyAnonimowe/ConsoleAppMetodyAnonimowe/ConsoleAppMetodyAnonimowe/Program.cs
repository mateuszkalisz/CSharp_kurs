using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMetodyAnonimowe
{
    class Program
    {
        delegate int PointToAddMethod(int a, int b);

        static void Main(string[] args)
        {
            //PointToAddMethod pointAdd = Add();

            PointToAddMethod pointAdd = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine(pointAdd.Invoke(2,3).ToString());
            Console.ReadKey();

        }

        //public static int Add(int a, int b)
        //{
        //    return a + b;
        //}

    }
}
