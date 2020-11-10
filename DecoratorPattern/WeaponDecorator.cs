using System;

namespace DecoratorPattern
{
    public class WeaponDecorator : Weapons
    {
        private Weapons _weapon;
        public override int DMG => _weapon.DMG;
        public override int Durability => _weapon.Durability;
        public override string Name => _weapon.Name;

        public WeaponDecorator(Weapons weapon) {
            this._weapon = weapon;
        }
    }
}
