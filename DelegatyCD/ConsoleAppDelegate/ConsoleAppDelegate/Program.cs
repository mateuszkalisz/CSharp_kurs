using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegate
{
    class Program
    {
        //delegate double CalculateAreaPointer(double r); //tworzymy delegata - musi byc utworzony do wszystkiego tutaj poza func, action, predicate
        //static CalculateAreaPointer cpointer = CalculateArea; //tworzymy zmienna - wskaznik delegata, ktory wskazuje na metode,
        
        static void Main(string[] args)
        {
            //double area = cpointer.Invoke(20);

            //tutaj wykorzystanie metody anonimowej
            //CalculateAreaPointer cpointer = new CalculateAreaPointer(delegate (double r)
            //    {
            //        return Math.PI * r * r;
            //    });

            //double area = cpointer(20);

            //wykorzystanie lambdy - zastąpienie zapisu
            //CalculateAreaPointer Cpointer = r => Math.PI * r * r;
            //double area = Cpointer(20);

            //func skraca tworzenie delegatow + jeszcze krocej dzieki lambdy czyli => , to samo jak za pomoca delegatow - to jest delegat ale duzo szybszy zapis
            //Func<double, double> Cpointer = r => Math.PI * r * r;
            //double area = Cpointer(20);

            //Action - delegat typu void
            //Action<string> MyAction = s => Console.WriteLine(s);
            //MyAction("to ja");

            //Predicate - rzadko uzywany, ale tez delegat - taki nietypowy delegat ktory zwraca tylko true or false
            Predicate<string> CheckIfStringIsGreatherThan5 = x => x.Length > 5;
            Console.WriteLine(CheckIfStringIsGreatherThan5("abdulhuehue"));
            Console.ReadKey();

        }

        //static double CalculateArea(double r) //jakas metoda
        //{
        //    return Math.PI * r * r;
        //}
    }
}
