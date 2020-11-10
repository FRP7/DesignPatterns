using System;

namespace DecoratorPattern
{
    public class Mace : Weapons
    {
        public override int DMG => 10;
        public override int Durability => 10;
        public override string Name => "Mace";
    }
}
