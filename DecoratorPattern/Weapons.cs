using System;

namespace DecoratorPattern
{
    public abstract class Weapons
    {
        public abstract int DMG { get; }
        public abstract int Durability { get; }
        public abstract string Name { get; }

        public virtual void Stats() {
            Console.WriteLine($"DMG: {DMG}");
            Console.WriteLine($"Durability: {Durability}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
