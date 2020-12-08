using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Magic : IAttack
    {
        public void Attack() {
            Console.WriteLine("Magic attack");
        }
    }
}
