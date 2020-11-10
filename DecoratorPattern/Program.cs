using System;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args) {
            Weapons sword = new Sword();
            Weapons axe = new Axe();
            Weapons mace = new Mace();
            Weapons runefire = new RuneFire(sword ,10, " Fire Rune");
            Weapons runedurability =
                new RuneDurability(axe, 10, " Durability Rune");

            Console.WriteLine("Espada: ");
            sword.Stats();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Machado: ");
            axe.Stats();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Maço: ");
            mace.Stats();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Espada com runa de fogo: ");
            runefire.Stats();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Machado com runa de durabilidade: ");
            runedurability.Stats();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
