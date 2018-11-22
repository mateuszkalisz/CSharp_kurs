using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDynamic
{
    class Program
    {
        static ExampleClass cls = new ExampleClass();
        static dynamic dls;

        static void Main(string[] args)
        {
            //int myInt = 1 + 3;
            //var myVar = 1 + 3;
            //dynamic myDynamic = 1 + 3;
            //object myObj = 1 + 3;

            //Console.WriteLine(myInt.GetType());
            //Console.WriteLine(myInt.GetType());
            //Console.WriteLine(myInt.GetType());
            //Console.WriteLine(myInt.GetType());

            dynamic dyna;

            int a = 20;
            dyna = a;

            string b = "blabla";
            dyna = b;

            DateTime dt = DateTime.Now;
            dyna = dt;


            dls = new ExampleClass();
            dls.ExampleMethod("blablabla");
            dls.ExampleMethod(); //celowy blad



            Console.ReadKey();


        }
    }

    public class ExampleClass
    {
        public void ExampleMethod(string text)
        {
            var a = text;
        }
    }

}
