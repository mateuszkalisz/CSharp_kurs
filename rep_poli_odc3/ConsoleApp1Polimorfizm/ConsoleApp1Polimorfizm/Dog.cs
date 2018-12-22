using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Polimorfizm
{
    class Dog : Animal, IPet, ICloth, IReactOnSound
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void GiveCloth()
        {
            throw new NotImplementedException();
        }

        public void GiveName()
        {
            throw new NotImplementedException();
        }

        public void RunToSoundSource()
        {
            throw new NotImplementedException();
        }
    }
}
