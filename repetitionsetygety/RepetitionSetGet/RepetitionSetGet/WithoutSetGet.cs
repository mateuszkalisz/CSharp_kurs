using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionSetGet
{
    class WithoutSetGet
    {
        private int level;

        public int GetLevel()
        {
            return level;
        }

        public void SetLevel (int _level)
        {
            level = _level;
        }
    }
}
