using AntLifePCL.TestClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tablica jednowymiarowa
            //int[] a = new int[3];

            //a[0] = 1;
            //a[1] = 3;
            //a[2] = 5;

            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            #endregion

            #region Tablica dwuwymiarowa
            //int[,] b = new int[10, 10];

            //b[0, 0] = 10;
            //b[0, 2] = 20;
            //b[1, 3] = 30;
            //b[2, 4] = 40;
            //b[5, 6] = 50;

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine(b[i,j]);
            //    }
            //}
            #endregion

            #region Tablica wyszczerbiona
            //int[][] c = new int[5][];
            //c[0] = new int[3];
            //c[1] = new int[5];
            //c[2] = new int[2];
            //c[3] = new int[4];
            //c[4] = new int[2];

            //c[0][0] = 1;
            //c[0][1] = 1;
            //c[0][2] = 1;
            //c[1][0] = 2;
            //c[1][1] = 2;
            //c[1][2] = 2;
            //c[1][3] = 2;
            //c[1][4] = 2;
            //c[2][0] = 3;
            //c[2][1] = 3;
            //c[3][0] = 4;
            //c[3][1] = 4;
            //c[3][2] = 4;
            //c[3][3] = 4;
            //c[4][0] = 5;
            //c[4][1] = 5;

            //for (int i = 0; i < c.Length; i++)
            //{
            //    for (int j = 0; j < c[i].Length; j++)
            //    {
            //        Console.WriteLine(c[i][j]);
            //    }
            //}

            #endregion

            #region Guid

            //int x = default(int); // defaultowo 0;

            //Console.WriteLine("x = " + x);

            //Guid y = new Guid();

            //y = default(Guid); // defaultowo 000-000-000000.... itd

            //Console.WriteLine("y = " + y);

            #endregion

            #region Dictionary
            //klucz nie moze sie powtarzac

            //Dictionary<int, TestClass> a = new Dictionary<int, TestClass>();

            //a.Add(1, new TestClass { TestClassID = 1, TestClassName = "test1" });
            //a.Add(2, new TestClass { TestClassID = 11, TestClassName = "test2" });
            //a.Add(3, new TestClass { TestClassID = 111, TestClassName = "test3" });
            //a.Add(4, new TestClass { TestClassID = 1111, TestClassName = "test4" });

            //foreach (var i in a)
            //{
            //    Console.WriteLine(i.Key + " | " + i.Value.TestClassID + " | " + i.Value.TestClassName);
            //}

            //Console.WriteLine(a[1].TestClassName); //pierwszyy element wg klucza (indeksu)
            //Console.WriteLine(a.ElementAt(0).Value.TestClassName; // pierwszy element wg indeksu jak dla tablic

            #endregion

            #region KeyValuePair
            //klucz moze sie powtarzac

            //KeyValuePair<int, TestClass> collectionA = new KeyValuePair<int, TestClass>(1, new TestClass { TestClassID = 1, TestClassName = "uwemheh1" });

            //KeyValuePair<int, TestClass> collectionB = new KeyValuePair<int, TestClass>(1, new TestClass { TestClassID = 2, TestClassName = "uwemheh2" });

            //List<KeyValuePair<int, TestClass>> listofKVP = new List<KeyValuePair<int, TestClass>>();

            //listofKVP.Add(collectionA);
            //listofKVP.Add(collectionB);

            #endregion

            

            Console.ReadKey();
            
        }
    }
}
