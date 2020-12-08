using System;

namespace StrategyPattern
{
    class Warrior : NPC
    {
        public override void Attack() {
            IAttack attack = new Sword();
            attack.Attack();
        }
    }
}
