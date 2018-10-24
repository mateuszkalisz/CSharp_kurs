using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace finalizacjaizapis
{
    class jakasklasacs
    {
        public int age;
        public string x;
        
        
        public void Metoda()
        {
            if (age >= 18)
            {
                
                string y = "Jesteś pełnoletni";
                Console.WriteLine(y);
                x = y;
                
             }
            else if (age > 0)
            {
                string y = "Jesteś niepełnoletni";
                Console.WriteLine(y);
                x = y;
            }

            else
            {
                string y = "Wpisałeś zły wiek";
                Console.WriteLine(y);
                x = y;
            
            }
                        
        }

        public void Metoda2()
        {
            if(age <0) throw new AggregateException(x);
        }

    }
}
