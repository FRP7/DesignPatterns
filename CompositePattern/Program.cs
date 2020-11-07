using System;

namespace CompositePattern
{
    /// <summary>
    /// Classe para mostrar e testar o programa.
    /// </summary>
    class Program 
    {
        static void Main(string[] args) {
            // Aceder à classe Barrack.
            Barrack barrack = new Barrack();
            //
            // Método para recrutar NPCs aleatórios.
            barrack.Recruit();
            //
        }
    }
    //
}
