using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Arrow : IAttack
    {
        public void Attack() {
            Console.WriteLine("Arrow attack");
        }
    }
}
