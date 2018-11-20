using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIEnumberableVSIEnumerator
{
    class Program
    {
        static void Main(string[] args)

        {
            List<int> myList = new List<int>();


            myList.Add(100);
            myList.Add(200);
            myList.Add(300);
            myList.Add(400);
            myList.Add(500);
            myList.Add(600);

            IEnumerable<int> ienumerable = myList.AsEnumerable(); // ienumerable nie wie w jakim stanie sie znajduje, dziedziczy z ienumerator wiec robi praktycznie to samo

            //foreach (var item in ienumerable)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator<int> ienumerator = myList.GetEnumerator(); // ienumerator - wie w jakim stanie sie znajduje

            //while (ienumerator.MoveNext())
            //{
            //    Console.WriteLine(ienumerator.Current.ToString());
            //}

            LoopTo300(ienumerator);
            LoopTo400(ienumerable);

            Console.ReadKey();

        }

        static void LoopTo300(IEnumerator<int> e)
        {
            while(e.MoveNext())
            {
                Console.WriteLine(e.Current.ToString());
                if(e.Current >299)
                {
                    LoopAbove300(e);
                }
            }
        }

        static void LoopAbove300(IEnumerator<int> e)
        {
            while(e.MoveNext())
            {
                Console.WriteLine(e.Current.ToString());
            }
        }

        static void LoopTo400(IEnumerable<int> eble)
        {
            foreach (var item in eble)
            {
                Console.WriteLine(item.ToString());
                if (item > 399)
                    LoopAbove400(eble);

            }
        }

        static void LoopAbove400(IEnumerable<int> eble)
        {
            foreach (var item in eble)
            {
                Console.WriteLine(item.ToString());
            }
        }


        
    }
}
