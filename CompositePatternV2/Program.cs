using System;

namespace CompositePatternV2
{
    /// <summary>
    /// Classe para experimentar a solução.
    /// </summary>
    class Program
    {
        static void Main(string[] args) {
            Cola colas = new Cola(210);
            colas.Flavors.Add(new VanillaCola(215));
            colas.Flavors.Add(new CherryCola(210));

            LemonLime lemonLime = new LemonLime(185);

            RootBeer rootBeers = new RootBeer(195);
            rootBeers.Flavors.Add(new VanillaRootBeer(200));
            rootBeers.Flavors.Add(new StrawberryRootBeer(200));

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();

        }
    }
}
