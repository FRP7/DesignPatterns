using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternV2
{
    /// <summary>
    /// Classe abstract para representar todas as soft drinks.
    /// </summary>
    public abstract class SoftDrink
    {
        // Variável int da quantidade de calorias de cada sabor.
        public int Calories { get; set; }
        //

        // Lista de sabores.
        public List<SoftDrink> Flavors { get; set; }
        //

        // Construtor de bebidas soft.
        public SoftDrink(int calories) {
            Calories = calories;
            Flavors = new List<SoftDrink>();
        }
        //

        // Método para mostrar as bebidas e respetivas calorias no ecrã.
        public void DisplayCalories() {
            Console.WriteLine(this.GetType().Name + ": " 
                + this.Calories.ToString() + " calories.");
            foreach(SoftDrink drink in this.Flavors) {
                drink.DisplayCalories();
            }
        }
        //
    }
    //
}
