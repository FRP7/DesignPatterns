using System;

namespace StrategyPattern
{
    class Ranger : NPC
    {
        public override void Attack() {
            IAttack attack = new Arrow();
            attack.Attack();
        }
    }
}
