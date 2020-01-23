using System;

namespace DoCopyConstructorsPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = new Line(new Point(1, 2),  new Point(3,4));
            var line2 = line.DeepCopyXml();
            line2.Start.X = 5;
            line2.Start.Y = 6;
            line2.End.X = 7;
            line2.End.Y = 8;
            Console.WriteLine(line);
            Console.WriteLine(line2);
        }
    }
}