using System;

using DoBridge.Abstraction;

namespace DoBridge.RefinedAbstraction
{
    class Customers : CustomersBase
    {
        public Customers(string group) : base(group) { }

        public override void ShowAll()
        {
            // Add separator lines

            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}