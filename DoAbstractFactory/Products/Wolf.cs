using System;
using DoAbstractFactory.AbstractProducts;

namespace DoAbstractFactory.Products
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }

      
    }
}
