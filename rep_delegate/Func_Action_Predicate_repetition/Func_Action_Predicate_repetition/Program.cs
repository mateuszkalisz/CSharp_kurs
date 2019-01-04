using System;

namespace Func_Action_Predicate_repetition
{
    class Program
    {
        //delegate double CalculateAreaDel(double r);
        //static CalculateAreaDel cpointer = CalculateArea;

        static void Main(string[] args)
        {
            //// double area = cpointer.Invoke(20);
            //CalculateAreaDel cpointer = new CalculateAreaDel(
            //                            delegate (double r)
            //                            {
            //                                return Math.PI * r * r;
            //                            }
            //    );

            //double area = cpointer(20);

            //CalculateAreaDel cpointer = r => Math.PI * r * r;
            //double area = cpointer(20);

            Func<double, double> cpointer = r => Math.PI * r * r;
            double area = cpointer(20);

            Action<string> MyAction = s => Console.WriteLine(s);
            MyAction("to ja");

            Predicate<string> CheckIfStringIsGreatherThanS = g => g.Length > 5;
            Console.WriteLine(CheckIfStringIsGreatherThanS("ala ma kota"));
        }

        //static double CalculateArea(double r)
        //{
        //    return Math.PI * r * r;
        //}
    }
}
