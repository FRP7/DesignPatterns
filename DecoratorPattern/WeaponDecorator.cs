using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Subclasse de Weapons onde se dá os upgrades.
    /// </summary>
    public class WeaponDecorator : Weapons
    {
        // Aceder à classe Weapons.
        private Weapons _weapon;
        //
        // O dano retorna o dano final da classe mãe.
        public override int DMG => _weapon.DMG;
        //
        // A durabilidade retorna a durabilidade final da classe mãe.
        public override int Durability => _weapon.Durability;
        //
        // O nome retorna o nome final da classe mãe.
        public override string Name => _weapon.Name;
        //

        // Construtor que define qual é o valor da variável _weapon.
        public WeaponDecorator(Weapons weapon) {
            this._weapon = weapon;
        }
        //
    }
    //
}
