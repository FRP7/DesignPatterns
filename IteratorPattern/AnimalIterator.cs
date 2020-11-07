using System;

namespace IteratorPattern
{
    /// <summary>
    /// Classe de iteração.
    /// </summary>
    class AnimalIterator : IAnimalIterator
    {
        // Aceder à classe AnimalCollection.
        private AnimalCollection _animalcollection;
        //

        // Definir qual é o elemento actual.
        private int Current = 0;
        //

        // Definir quanto é o próximo elemento a seguir.
        private int Step = 1;
        //

        /// <summary>
        /// Construtor da iteração.
        /// </summary>
        /// <param name="animalcollection"> Coleção de animais. </param>
        public AnimalIterator(AnimalCollection animalcollection) {
            this._animalcollection = animalcollection;
        }
        //

        /// <summary>
        ///  Primeiro animal.
        /// </summary>
        /// <returns> Retoma o elemento do inicío da
        /// coleção (elemento zero). </returns>
        public Animal First() {
            // Definir o elemento actual a zero.
            Current = 0;
            //

            // Retomar o elemento do inicío da coleção (elemento zero).
            return _animalcollection[Current] as Animal;
            //
        }
        //

        /// <summary>
        /// Último animal.
        /// </summary>
        /// <returns> Retoma o último elemento da coleção. </returns>
        public Animal Last() {
            // Definir o elemento actual ao último da coleção.
            Current = _animalcollection.Count - 1;
            //

            // Retomar o último elemento da coleção.
            return _animalcollection[Current] as Animal;
            //
        }
        //

        /// <summary>
        /// Próximo animal.
        /// </summary>
        /// <returns> Retoma ou o próximo elemento da 
        /// coleção ou nada.</returns>
        public Animal Next() {
            /* O elemento actual a incrementar com o valor necessário para
             * próximo elemento. */
            Current += Step;
            //

            /* Verificar se a iteração está finalizada. Se tiver finalizada
             * não retoma valor, se ainda não estiver retoma o próximo
             * elemento da coleção. */
            if(!isDone) {
                // Retoma o próximo elemento da coleção.
                return _animalcollection[Current] as Animal;
                //
            }
            else {
                // Retoma nada.
                return null;
                //
            }
            //
        }
        //

        // Variável de leitura para mostrar qual é o animal actual.
        public Animal CurrentAnimal {
            // Mostrar o elemento actual da coleção de animais.
            get { return _animalcollection[Current] as Animal; }
            //
        }
        //

        // Variável de leitura para mostrar se a iteração está terminada.
        public bool isDone {
            /* Mostrar qual é o elemento actual caso seja maior ou igual 
             * ao número de animais. */
            get { return Current >= _animalcollection.Count; }
            //
        }
        //
    }
}
