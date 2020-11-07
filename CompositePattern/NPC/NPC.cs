using System;

namespace CompositePattern
{
    abstract class NPC // Responsabilidade: definir os NPCs (global).
    {
        protected abstract int HP { get; set; }
        protected abstract int DMG { get; set; }
        protected abstract string Name { get; set; }

    }
}
