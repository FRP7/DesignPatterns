using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Subclasse de Weapons que representa uma maça.
    /// </summary>
    public class Mace : Weapons
    {
        // Definir o dano.
        public override int DMG => 10;
        //
        // Definir a durabilidade.
        public override int Durability => 10;
        //
        // Definir o nome.
        public override string Name => "Mace";
        //
    }
    //
}
