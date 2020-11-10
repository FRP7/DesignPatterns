using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Subclasse de WeaponDecorator faz upgrade.
    /// </summary>
    public class RuneDurability : WeaponDecorator
    {
        // Durabilidade a ser somada em caso de upgrade.
        private int AddDurability;
        //
        // Nome a ser somado em caso de upgrade.
        private string AddName;
        //
        // Somar a durabilidade da classe mãe com o dano adicional.
        public override int Durability => base.Durability + AddDurability;
        //
        // Somar o nome da classe mãe com o nome adicional.
        public override string Name => base.Name + AddName;
        //

        // Construtor de RuneDurability. Aqui é definido os valores do upgrade.
        public RuneDurability(Weapons weapon, int addurability, 
            string addname) : base(weapon) {
            this.AddDurability = addurability;
            this.AddName = addname;
        }
        //
    }
    //
}
