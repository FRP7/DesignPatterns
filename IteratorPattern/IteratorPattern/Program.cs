using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args) {
            // Definir uma coleção de animais.
            AnimalCollection _animalcollection = new AnimalCollection();
            _animalcollection[0] = new Animal("Gato");
            _animalcollection[1] = new Animal("Cão");
            _animalcollection[2] = new Animal("Pássaro");
            _animalcollection[3] = new Animal("Coelho");
            _animalcollection[4] = new Animal("Hamster");
            //

            // Chamar método para criar iteração.
            AnimalIterator _animaliterator =
                _animalcollection.CreateIterator();
            //

            Console.WriteLine($"Número de animais: {_animalcollection.Count}");

            Console.WriteLine("Lista de Animais: ");

            // Mostrar no ecrã os animais.
            for(Animal item = _animaliterator.First();
                !_animaliterator.isDone;  item = _animaliterator.Next()) {
                Console.WriteLine(item.GetName);
            }
            //

            Console.WriteLine($"Primeiro animal: {_animaliterator.First().GetName}");
            Console.WriteLine($"Último animal: {_animaliterator.Last().GetName}");
        }
    }
}
