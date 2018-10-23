using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyjatekThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wiek: ");
            age wiek = new age();
            wiek.ages = int.Parse(Console.ReadLine());
                                   
            try
            {
                wiek.agesMethod();
            }

            catch(ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

            
            Console.ReadKey();

        }
    }
}
