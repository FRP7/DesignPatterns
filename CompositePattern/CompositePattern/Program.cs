using System;

namespace CompositePattern
{
    class Program // responsabilidade: mostrar e testar o programa
    {
        static void Main(string[] args) {
            Barrack barrack = new Barrack();
            barrack.Recruit();
        }
    }
}
