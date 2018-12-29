using System;

namespace RepetitionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            OtherBasicMehod sm = new OtherBasicMehod();
            sm.SomeMethod(CallBackMethod);
            Console.ReadKey();
        }

        static void CallBackMethod(int i)
        {
            Console.WriteLine(i);
        }
    }

    class OtherBasicMehod
    {
        public delegate void CallBack(int i);

        public void SomeMethod(CallBack obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                //robi cos sie w tle....
                obj(i);
            }
            Console.ReadKey();
        }
    }
}
