using System;

namespace DecoratorPattern
{
    /// <summary>
    /// Classe para testar a solução.
    /// </summary>
    public class Program
    {
        static void Main(string[] args) {
            // Aceder à subclasse Sword.
            Weapons sword = new Sword();
            //
            // Aceder à subclasse Axe.
            Weapons axe = new Axe();
            //
            // Aceder à subclasse Mace.
            Weapons mace = new Mace();
            //
            // Construir e aceder ao upgrade RuneFire. Colocar na espada.
            Weapons runefire = new RuneFire(sword ,10, " Fire Rune");
            //
            /* Construir e aceder ao upgrade RuneDurability.
             * Colocar no machado. */
            Weapons runedurability =
                new RuneDurability(axe, 10, " Durability Rune");
            //

            // Mostrar no ecrã os stats da espada.
            Console.WriteLine("Espada: ");
            sword.Stats();
            Console.WriteLine(Environment.NewLine);
            //
            // Mostrar no ecrã os stats do machado.
            Console.WriteLine("Machado: ");
            axe.Stats();
            Console.WriteLine(Environment.NewLine);
            //
            // Mostrar no ecrã os stats do maço.
            Console.WriteLine("Maço: ");
            mace.Stats();
            Console.WriteLine(Environment.NewLine);
            //
            // Mostrar no ecrã os stats da espada com a runa de fogo.
            Console.WriteLine("Espada com runa de fogo: ");
            runefire.Stats();
            Console.WriteLine(Environment.NewLine);
            //
            // Mostrar no ecrã os stats do machado com a runa de durabilidade.
            Console.WriteLine("Machado com runa de durabilidade: ");
            runedurability.Stats();
            Console.WriteLine(Environment.NewLine);
            //
        }
    }
    //
}
