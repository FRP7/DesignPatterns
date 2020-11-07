using System;

namespace CompositePattern
{
    /// <summary>
    /// Classe de recrutamento de NPCs aleatórios.
    /// </summary>
    class Barrack 
    {
        // Método de recrutamento de NPCs aleatórios.
        public void Recruit() {
            // Array de interfaces de IAttack.
            IAttack[] iattack = new IAttack[3];
            //
            // Criar um número random.
            Random random = new Random();
            int rndnumber = random.Next(1, 4);
            //

            /* Caso seja um dos números, é construído a respetiva unidade,
             * adicionado à array e depois a respetiva interface é chamada. */
            if(rndnumber == 1) {
                iattack[0] = new Tank();
                iattack[0].Attack();
            }
            if (rndnumber == 2) {
                iattack[1] = new Healer();
                iattack[1].Attack();
            }
            if (rndnumber == 3) {
                iattack[2] = new Infantry();
                iattack[2].Attack();
            }
            //
        }
        //
    }
    //
}
