using System;

namespace TemplatePattern
{
    abstract class Animal
    {
        public abstract void Move();
        public abstract void Eat();
        public abstract void Sleep();
        public virtual void Hunt() {
            Console.WriteLine("Hunt");
        }
    }
}
