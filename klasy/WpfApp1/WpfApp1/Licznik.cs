using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Licznik
    {
        public int AddTwoNumbers(int a, int b)
        {
            if (a == null || b == null) 
            {
                return 0;
            }
            else
            {
                return a + b;
            }
            
        }


    }
}
