using System;

namespace CompositePattern
{
    class Healer : NPC, IAttack // Responsabilidade: definir o NPC Healer.
    {
        protected override int HP { get; set; }
        protected override int DMG { get; set; }
        protected override string Name { get; set; }

        // Construtor de Healer
        public Healer() {
            HP = 5;
            DMG = 2;
            Name = "Healer";
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
