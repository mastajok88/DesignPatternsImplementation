using System;

namespace DoFunctionalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var personBuilder = new PersonBuilder();
            var person = personBuilder.Called("Artem").WorksAsA("Developer").Build();
            Console.WriteLine(person);
        }
    }
}