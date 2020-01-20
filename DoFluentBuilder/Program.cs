using System;

namespace DoFluentBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var me = Person.New
                .Called("Dmitri")
                .WorksAsA("Quant")
                .Born(DateTime.UtcNow)
                .Build();
            Console.WriteLine(me);

            Console.WriteLine(me);
        }
    }
}