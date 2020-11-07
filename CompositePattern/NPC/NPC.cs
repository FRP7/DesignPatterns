using System;

namespace CompositePattern
{
    /// <summary>
    /// Classe abstracta que define como são os NPCs globalmente.
    /// </summary>
    abstract class NPC 
    {
        // Variável da vida.
        protected abstract int HP { get; set; }
        //
        // Variável da quantidade de dano que dá.
        protected abstract int DMG { get; set; }
        //
        // Variável do nome do NPC.
        protected abstract string Name { get; set; }
        //

    }
    //
}
