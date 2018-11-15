using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OdwolanieDoNazwanejMetodyiNie
{
    class Program
    {

        delegate int PointToAddMethod(int a, int b);

        static void Main(string[] args)
        {

            // delegat bez odwolania do metody
            //Stopwatch timerObj = new Stopwatch();

            //for (int i = 0; i < 10; i++)
            //{
            //    timerObj.Reset();
            //    timerObj.Start();

            //    for (int j = 0; j < 100000; j++)
            //    {
            //        PointToAddMethod pointAdd = delegate (int a, int b)
            //        {
            //            return a + b;
            //        };

            //        int c = pointAdd.Invoke(2, 3);
            //    }

            //    timerObj.Stop();
            //    Console.WriteLine(timerObj.ElapsedTicks.ToString());
            //}

            //tikirikitiki:
            //5161
            //4828
            //4489
            //4465
            //6828
            //6618
            //5815
            //4741
            //5068
            //5191

            // delegat z odwolaniem odwolania do metody


            Stopwatch timerObj = new Stopwatch();

                for (int i = 0; i < 10; i++)
                {
                    timerObj.Reset();
                    timerObj.Start();

                    for (int j = 0; j < 100000; j++)
                    {
                    PointToAddMethod pointAdd = Add;
                    int c = pointAdd.Invoke(2, 3);
                    }

                    timerObj.Stop();
                    Console.WriteLine(timerObj.ElapsedTicks.ToString());
                }
            //tikirikitiki:
            //17373
            //7592
            //13468
            //10600
            //9611
            //11700
            //8011
            //6865
            //6737
            //6687

                Console.ReadKey();

        }

        static int Add(int a, int b)
        {
            return a + b;
        }

    }

    

}

//1 skrocenie kodu ktory niewiele robi i jest zbedny jako metoda (overhead)
//2 szybkosc metody anonimowej w odniesieniu do metody nazwanej