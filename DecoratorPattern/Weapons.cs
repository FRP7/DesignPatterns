using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Classe abstract mãe das armas.
    /// </summary>
    public abstract class Weapons
    {
        // Definir o dano.
        public abstract int DMG { get; }
        //
        // Definir a durabilidade.
        public abstract int Durability { get; }
        //
        // Definir o nome.
        public abstract string Name { get; }
        //

        // Método para mostrar os stats.
        public virtual void Stats() {
            Console.WriteLine($"DMG: {DMG}");
            Console.WriteLine($"Durability: {Durability}");
            Console.WriteLine($"Name: {Name}");
        }
        //
    }
    //
}
