using System;
using System.Runtime.CompilerServices;

namespace CompositePattern
{
    class Infantry : NPC, IAttack // Responsabilidade: definir o NPC Infantry.
    {
        protected override int HP { get; set; }
        protected override int DMG { get; set; }
        protected override string Name { get; set; }

        // Construtor de Infantry
        public Infantry() {
            HP = 10;
            DMG = 5;
            Name = "Infantry";
            // só pa testar, delete later
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"DMG: {DMG}");
        }
        //

        public bool Attack() {
            Random random = new Random();
            int rndnumber = random.Next(1, 3);
            if (rndnumber == 1) {
                return true;
            } else {
                return false;
            }
        }
    }
}
