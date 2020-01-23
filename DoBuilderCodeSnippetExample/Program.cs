using System;

namespace DoBuilderCodeSnippetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //build object piece by piece
            var cc = new CodeClassBuilder("Person")
                .AddField("Age", "int")
                .AddField("Name", "string")
                .Build();
            
            Console.WriteLine(cc);
        }
    }
}
