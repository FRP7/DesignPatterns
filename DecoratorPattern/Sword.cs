using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Subclasse de Weapons que representa uma espada.
    /// </summary>
    public class Sword : Weapons
    {
        // Definir o dano.
        public override int DMG => 5;
        //
        // Definir a durabilidade.
        public override int Durability => 10;
        //
        // Definir o nome.
        public override string Name => "Sword";
        //
    }
}
