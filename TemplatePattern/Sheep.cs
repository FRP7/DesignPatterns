using System;

namespace TemplatePattern
{
    class Sheep : Animal
    {
        public override void Move() {
            Console.WriteLine("Sheep moves");
        }
        public override void Eat() {
            Console.WriteLine("Sheep eats");
        }
        public override void Sleep() {
            Console.WriteLine("Sheep sleeps");
        }
    }
}
