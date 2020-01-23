using System;

namespace DoFactoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var personFactory = new PersonFactory();
            var singletoneTester = new SigletonTester();
            Func<(IPerson, int)> createPerson = () => personFactory.Create("Artem");
            Console.WriteLine(personFactory.Create("Artem"));
            
            
            
            Console.WriteLine(personFactory.Create("John"));
            Console.WriteLine(personFactory.Create("Peter"));

            var isSingleton = singletoneTester.IsSingleton(createPerson);


            Console.WriteLine(isSingleton);
        }
    }
}