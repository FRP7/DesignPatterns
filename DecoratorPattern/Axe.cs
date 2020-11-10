using System;

namespace DecoratorPattern
{
    public class Axe : Weapons
    {
        public override int DMG => 10;
        public override int Durability => 5;
        public override string Name => "Axe";
    }
}
