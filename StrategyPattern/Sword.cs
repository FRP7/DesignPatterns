using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Sword : IAttack
    {
        public void Attack() {
            Console.WriteLine("Sword attack");
        }
    }
}
