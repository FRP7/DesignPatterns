using System;

namespace IteratorPattern
{
    /// <summary>
    /// Classe para representar um animal.
    /// </summary>
    class Animal
    {
        // Nome do animal.
        private string Name { get; set; }
        //

        /// <summary>
        /// Construtor de animais.
        /// </summary>
        /// <param name="name"> Nome do animal. </param>
        public Animal(string name) {
            Name = name;
        }
        //

        // Variável de leitura para mostrar o nome do animal.
        public string GetName {
            // Mostrar o nome.
            get { return Name;  }
            //
        }
        //
    }
}
