using System;

namespace DecoratorPattern
{
    public class RuneDurability : WeaponDecorator
    {
        private int AddDurability;
        private string AddName;
        public override int Durability => base.Durability + AddDurability;
        public override string Name => base.Name + AddName;

        public RuneDurability(Weapons weapon, int addurability, 
            string addname) : base(weapon) {
            this.AddDurability = addurability;
            this.AddName = addname;
        }
    }
}
