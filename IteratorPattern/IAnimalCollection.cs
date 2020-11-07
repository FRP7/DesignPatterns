using System;

namespace IteratorPattern
{
    /// <summary>
    /// Interface de agregação.
    /// </summary>
    interface IAnimalCollection
    {
        // Criar iteração.
        AnimalIterator CreateIterator();
        //
    }
    ///
}
