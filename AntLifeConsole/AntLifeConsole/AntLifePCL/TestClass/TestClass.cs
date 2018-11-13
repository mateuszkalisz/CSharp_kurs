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

        #region Wykorzystanie pol zamiast hermetyzowania zmiennej

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

        #endregion

        
        #region Hermetyzacja zmiennej

        private int _wiek;

        public int GetAge()
        {
            return _wiek;
        }

        public void SetAge(int wiek)
        {
            _wiek = wiek;
        }

        #endregion

    }
}
