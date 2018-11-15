using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Wolf, IPet, ICloth, IReactOnSound
    {
        //mozna metody eat nie pisac bo wilk juz korzysta z tej metody i dog dziedziczy
        public override void Eat()
        {
            base.Eat();
        }

        public void GiveCloth()
        {
            throw new NotImplementedException();
        }

        public void GiveName()
        {
            throw new NotImplementedException();
        }

        public void RunToSound()
        {
            throw new NotImplementedException();
        }
    }
}
