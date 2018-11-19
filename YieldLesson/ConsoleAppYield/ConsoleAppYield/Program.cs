using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYield
{
    class Program
    {
        static List<int> myList = new List<int>();

        static void Main(string[] args)
        {
            FillList();
            foreach (var item in Filter())
            {
                Console.WriteLine(item);
            }

            foreach (var item in Total())
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

        }

        private static void FillList()
        {
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);
            myList.Add(7);
        }

        //Custom iteration
        static IEnumerable<int> Filter()
        {
            //List<int> tmp = new List<int>();
            foreach (var item in myList)
            {
                if(item>3)
                {
                    //tmp.Add(item);
                    yield return item;
                }
            }
            //return tmp;

        }

        //Statefull iteration
        static IEnumerable<int> Total()
        {
            int totalNumber = 0;
            foreach (var item in myList)
            {
                totalNumber += item;
                yield return (totalNumber);
            }
        }

    }


}
