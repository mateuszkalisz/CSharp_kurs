using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace finalizacjaizapis
{
    class Program
    {

        static void Main(string[] args)
        {
            //StreamWriter file = new StreamWriter("ZapisPliku.txt");

            
                jakasklasacs wiek = new jakasklasacs();

                Console.WriteLine("Podaj wiek: ");
                wiek.age = int.Parse(Console.ReadLine());

            using (StreamWriter file = new StreamWriter("pliktekstowy.txt", true))
            {
                wiek.Metoda();
                string y = wiek.x;
                file.WriteLine(y);
                
            }

            wiek.Metoda2();
            Console.ReadKey();


                    //finally
                    //{
                    //    file.Close();
                    //}
                
            
        }
    }
}

                   
            
                
            
            


        


    

