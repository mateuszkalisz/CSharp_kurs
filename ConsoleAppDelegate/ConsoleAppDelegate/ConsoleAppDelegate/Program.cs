using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    class Program
    {
      
        static void Main(string[] args)
        {
            SomeLongRunningData SomeData = new SomeLongRunningData();
            SomeData.SomeMethod(CallBackMethod);

        }

        static void CallBackMethod(int i)
        {
            Console.WriteLine(i + "bla");
        }

    

    }

    class SomeLongRunningData
    {
        public delegate void CallBack(int i);

        public void SomeMethod(CallBack obj)
        {
            Console.WriteLine("Robi się coś tam i inne rzeczy w tle... ");

            for (int i = 0; i < 1000; i++)
            {
                obj(i);
                
            }

            Console.ReadKey();
        }

    }

}
