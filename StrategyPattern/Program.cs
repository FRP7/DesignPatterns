using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args) {
            Warrior warrior = new Warrior();
            warrior.Attack();
            Mage mage = new Mage();
            mage.Attack();
            Ranger ranger = new Ranger();
            ranger.Attack();
        }
    }
}
