using System;

namespace TemplatePattern
{
    class Wolf : Animal
    {
        public override void Move() {
            Console.WriteLine("Wolf moves");
        }
        public override void Eat() {
            Console.WriteLine("Wolf eats");
        }
        public override void Sleep() {
            Console.WriteLine("Wolf sleeps");
        }
        public override void Hunt() {
            Console.WriteLine("Wolf");
            base.Hunt();
        }
    }
}
