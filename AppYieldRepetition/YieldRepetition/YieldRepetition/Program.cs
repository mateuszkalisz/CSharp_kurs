using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldRepetition
{
    class Program
    {
        static List<int> myList = new List<int>();

        static void Main(string[] args)
        {

            Console.WriteLine("custom iteration");

            FillList();

            foreach (var item in Filter())
            { 
                Console.WriteLine(item);
            }

            Console.WriteLine("statefull iteration");

            foreach (var item in Total())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

        static void FillList()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
        }


        // Custom Iteration
        static IEnumerable<int> Filter()
        {
            foreach (var item in myList)
            {
                if (item > 3)
                    yield return item;
            }
        }

        // statefull iteration

        static IEnumerable<int> Total()
        {
            int totalSUM = 0;

            foreach (var item in myList)
            {
                totalSUM += item;
                yield return totalSUM;
            }

        }

    }
}
