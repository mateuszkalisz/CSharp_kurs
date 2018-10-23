using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatekThrow
{
    class age
    {
        public int ages;
        
        public void agesMethod()
        {

            if (ages>=18)
            {
                Console.WriteLine("Jestes pelnoletni");
            }

            else if(ages>0)
            {
                Console.WriteLine("Jesteś niepełnoletni");
            }

            else
            {
                throw new ArgumentException("Podaj poprawny wiek!");
            }
                          
        }

    }
}
