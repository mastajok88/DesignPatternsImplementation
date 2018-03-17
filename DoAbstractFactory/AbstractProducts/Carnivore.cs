using DoAbstractFactory.AbstractFactory;
using DoAbstractFactory.Products;

namespace DoAbstractFactory.AbstractProducts
{
    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);


        
    }
}