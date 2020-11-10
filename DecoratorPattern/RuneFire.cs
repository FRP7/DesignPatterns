using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Subclasse de WeaponDecorator faz upgrade.
    /// </summary>
    public class RuneFire : WeaponDecorator
    {
        // Dano a ser somado em caso de upgrade.
        private int AdditionalDMG;
        //
        // Nome a ser somado em caso de upgrade.
        private string AdditionalName;
        //
        // Somar o dano da classe mãe com o dano adicional.
        public override int DMG => base.DMG + AdditionalDMG;
        //
        // Somar o nome da classe mãe com o nome adicional.
        public override string Name => base.Name + AdditionalName;
        //

        // Construtor de RuneFire. Aqui é definido os valores do upgrade.
        public RuneFire(Weapons weapon, int additionaldmg,
            string additionalname) : base(weapon) {
            this.AdditionalDMG = additionaldmg;
            this.AdditionalName = additionalname;
        }
        //
    }
    //
}
