using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntLifePCL.TestClass
{
    public class TestClass
    {
        public int TestClassID { get; set; }
        public string TestClassName { get; set; }

        private int naszaKlasa;

        public int NaszaKlasa
        {
            get { return naszaKlasa; }
            set
            {
                if (naszaKlasa < 10)
                {
                    naszaKlasa = 10;
                }
                    
                else
                {
                    naszaKlasa = value;
                }
                    
            }
        }

        

    }
}
