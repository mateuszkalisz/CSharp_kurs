using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat_MZ
{
    class Program
    {
        static void Main(string[] args)
        {
        public delegate void Writer(string message);


        static Logger logger = new Logger();
        Writer writer = new Writer(logger.WriteMessage);

        public Writer("blabla");
        }
    }
}
    

    

 