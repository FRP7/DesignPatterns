using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Subclasse de Weapons que representa um machado.
    /// </summary>
    public class Axe : Weapons
    {
        // Definir o dano.
        public override int DMG => 10;
        //
        // Definir a durabilidade.
        public override int Durability => 5;
        //
        // Definir o nome
        public override string Name => "Axe";
        //
    }
    //
}
