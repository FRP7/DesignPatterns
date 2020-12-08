using System;

namespace StrategyPattern
{
    class Mage : NPC
    {
        public override void Attack() {
            IAttack attack = new Magic();
            attack.Attack();
        }
    }
}
