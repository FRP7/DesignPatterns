using System;

namespace DecoratorPattern
{
    public class Sword : Weapons
    {
        public override int DMG => 5;
        public override int Durability => 10;
        public override string Name => "Sword";
    }
}
