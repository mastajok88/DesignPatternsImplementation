using System;
using DoAbstractFactory.AbstractProducts;

namespace DoAbstractFactory.Products
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }

      
    }
}
