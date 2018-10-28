using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            int variable1 = 10;
            int variable2 = 20;

            int variable3 = 10;
            string variable4 = "20";

            //Operatory matematyczne
            var result1 = (float)variable1 + variable2;
            var result2 = variable1 - variable2;
            var result3 = variable1 * variable2;
            var result4 = variable1 / variable2;
            var result5 = variable1 % variable2;

            var result6 = variable1++; // 10 + 1
            var result7 = variable1--; // 10 - 1

            var result8 = variable3 + variable4;

            //Operatory logiczne
            var result9 = (variable1 == variable2); // false
            var result10 = (variable1 != variable2); // true
            var result11 = (variable1 > variable2); // false
            var result12 = (variable1 >= variable2); // false
            var result13 = (variable1 < variable2); // true
            var result14 = (variable1 <= variable2); // true

            //Operatory mat - sztuczki
            variable1 += variable2; // variable1 = variable1 + variable2;
            variable1 =+ variable2; // variable1 = variable2 + variable1
            variable1 -= variable2; // variable1 = variable1 - variable2;
            variable1 *= variable2; // variable1 = variable1 * variable2;

        }
    }
}
