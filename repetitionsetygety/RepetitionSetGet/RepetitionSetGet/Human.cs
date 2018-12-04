using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionSetGet
{
    class Human
    {
        private int wiek;

    public int Wiek
        {
            get
            {
                return wiek;
            }

            set
            {
                    if(value>0 && value <100)
                {
                    wiek = value;
                }
                    else

                {
                    wiek = 0;
                }
                    
                
            }
        }

    }
}
