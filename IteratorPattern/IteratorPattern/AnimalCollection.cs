using System;
using System.Collections;

namespace IteratorPattern
{
    /// <summary>
    /// Classe de agregação.
    /// Representa a coleção de animais.
    /// </summary>
    class AnimalCollection : IAnimalCollection
    {
        // ArrayList de animais.
        private ArrayList Items = new ArrayList();
        //

        /// <summary>
        /// Criar iteração.
        /// </summary>
        /// <returns> Retoma uma nova iteração. </returns>
        public AnimalIterator CreateIterator() {
            // Retomar iteração.
            return new AnimalIterator(this);
            //
        }
        //

        // Variável de leitura para mostrar o número de animais.
        public int Count {
            // Mostrar o número de items na ArrayList.
            get { return Items.Count; }
            //
        }
        //

        /// <summary>
        /// Indexador.
        /// </summary>
        /// <param name="index"> Index. </param>
        /// <returns> Mostrar o elemento (de acordo com o index). </returns>
        public object this[int index] {
            // Mostrar o elemento (de acordo com o index).
            get { return Items[index]; }
            //
            // Adicionar elemento à ArrayList.
            set { Items.Add(value); }
            //
        }
        //
    }
    ///
}
