using System;

namespace CompositePattern
{
    /// <summary>
    /// Subclasse de NPC que define como vai ser o NPC Tank.
    /// </summary>
    class Tank : NPC, IAttack 
    {
        // Variável da vida.
        protected override int HP { get; set; }
        //
        // Variável do dano que causa.
        protected override int DMG { get; set; }
        //
        // Variável do nome do NPC.
        protected override string Name { get; set; }
        //

        // Construtor de Tank
        public Tank() {
            // Definir os valores.
            HP = 20;
            DMG = 10;
            Name = "Tank";
            //
        }
        //

        // Método que verifica se ataca.
        public bool Attack() {
            Random random = new Random();
            int rndnumber = random.Next(1,3);
            if(rndnumber == 1) {
                return true;
            } else {
                return false;
            }
        }
        //
    }
}
