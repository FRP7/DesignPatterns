using System;

namespace CompositePattern
{
    /// <summary>
    /// Subclasse de NPC que define como vai ser o NPC Infantry.
    /// </summary>
    class Infantry : NPC, IAttack 
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

        // Construtor de Infantry
        public Infantry() {
            // Definir os valores
            HP = 10;
            DMG = 5;
            Name = "Infantry";
            //
        }
        //

        // Método que verifica se ataca.
        public bool Attack() {
            Random random = new Random();
            int rndnumber = random.Next(1, 3);
            if (rndnumber == 1) {
                return true;
            } else {
                return false;
            }
        }
        //
    }
}
