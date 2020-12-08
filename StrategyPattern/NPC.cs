using System;

namespace StrategyPattern
{
    abstract class NPC : IAttack
    {
        public abstract void Attack();
    }
}
