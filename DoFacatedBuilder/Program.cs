using System;

namespace DoFacatedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var pb = new PersonBuilder();
            Person person = pb.Works.As("Developer").At("Company").Earning(3000)
                .Lives.In("Riga").At("123").WithPostcode("321");
            
            Console.WriteLine(person);
        }
    }
}