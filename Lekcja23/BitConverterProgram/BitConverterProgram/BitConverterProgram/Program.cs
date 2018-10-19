using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitConverterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteByte returnvalue = new WriteByte();
            returnvalue.WriteAsByte(256);
            Console.ReadKey();


        }
    }
}
