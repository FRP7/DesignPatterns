using System;

namespace DecoratorPattern
{
    public class RuneFire : WeaponDecorator
    {
        private int AdditionalDMG;
        private string AdditionalName;
        public override int DMG => base.DMG + AdditionalDMG;
        public override string Name => base.Name + AdditionalName;

        public RuneFire(Weapons weapon, int additionaldmg,
            string additionalname) : base(weapon) {
            this.AdditionalDMG = additionaldmg;
            this.AdditionalName = additionalname;
        }
    }
}
