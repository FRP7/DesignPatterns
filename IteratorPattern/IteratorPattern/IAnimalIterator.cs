using System;

namespace IteratorPattern
{
    /// <summary>
    /// Interface de iteração.
    /// </summary>
    interface IAnimalIterator
    {
        // Primeiro animal.
        Animal First();
        //

        // Último Animal.
        Animal Last();
        //

        // Próximo animal.
        Animal Next();
        //

        // Variável de leitura para mostrar qual é o animal actual.
        bool isDone { get; }
        //
        // Iteração actual.
        Animal CurrentAnimal { get; }
        //
    }
    ///
}
