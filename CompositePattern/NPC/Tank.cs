using System;

namespace CompositePattern
{
    class Tank : NPC, IAttack // Responsabilidade: definir o NPC Tank.
    {
        protected override int HP { get; set; }
        protected override int DMG { get; set; }
        protected override string Name { get; set; }

        // Construtor de Tank
        public Tank() {
            HP = 20;
            DMG = 10;
            Name = "Tank";
            // só pa testar, delete later
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"DMG: {DMG}");
        }
        //

        public bool Attack() {
            Random random = new Random();
            int rndnumber = random.Next(1,3);
            if(rndnumber == 1) {
                return true;
            } else {
                return false;
            }
        }
    }
}
