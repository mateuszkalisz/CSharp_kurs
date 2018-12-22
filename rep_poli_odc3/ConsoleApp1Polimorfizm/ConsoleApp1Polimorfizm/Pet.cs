using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1Polimorfizm
{
    public class Pet : Animal, IPet
    {
        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public virtual void GiveName() { }
    }
}
