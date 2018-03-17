using DoAbstractFactory.AbstractFactory;
using DoAbstractFactory.AbstractProducts;
using DoAbstractFactory.Products;

namespace DoAbstractFactory.Factory
{
    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
