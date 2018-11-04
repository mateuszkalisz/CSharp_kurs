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
            int[] a = new int[3];

            a[0] = 1;
            a[1] = 3;
            a[2] = 5;

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            #endregion

            #region Tablica dwuwymiarowa
            int[,] b = new int[10, 10];

            b[0, 0] = 10;
            b[0, 2] = 20;
            b[1, 3] = 30;
            b[2, 4] = 40;
            b[5, 6] = 50;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(b[i,j]);
                }
            }
            #endregion

            #region Tablica wyszczerbiona
            int[][] c = new int[5][];
            c[0] = new int[3];
            c[1] = new int[5];
            c[2] = new int[2];
            c[3] = new int[4];
            c[4] = new int[2];

            c[0][0] = 1;
            c[0][1] = 1;
            c[0][2] = 1;
            c[1][0] = 2;
            c[1][1] = 2;
            c[1][2] = 2;
            c[1][3] = 2;
            c[1][4] = 2;
            c[2][0] = 3;
            c[2][1] = 3;
            c[3][0] = 4;
            c[3][1] = 4;
            c[3][2] = 4;
            c[3][3] = 4;
            c[4][0] = 5;
            c[4][1] = 5;

            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c[i].Length; j++)
                {
                    Console.WriteLine(c[i][j]);
                }
            }

             #endregion

            Console.ReadKey();
        }
    }
}
