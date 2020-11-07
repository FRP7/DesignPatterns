using System;

namespace CompositePattern
{
    class Barrack // Responsabilidade: recrutar NPCs aleatórios
    {
        public void Recruit() {
            IAttack[] iattack = new IAttack[3];
            Random random = new Random();
            int rndnumber = random.Next(1, 4);

            if(rndnumber == 1) {
                iattack[0] = new Tank();
                Console.WriteLine("Attack: " + iattack[0].Attack());
            }
            if (rndnumber == 2) {
                iattack[1] = new Healer();
                Console.WriteLine("Attack: " + iattack[1].Attack());
            }
            if (rndnumber == 3) {
                iattack[2] = new Infantry();
                Console.WriteLine("Attack: " + iattack[2].Attack());
            }
        }
    }
}
