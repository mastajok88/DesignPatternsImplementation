using DoAbstractFactory.AbstractFactory;
using DoAbstractFactory.AbstractProducts;
using DoAbstractFactory.Products;

namespace DoAbstractFactory.Factory
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }
    }
}
