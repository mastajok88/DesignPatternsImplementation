using System;

using DoBridge.ConcreteImplementor;
using DoBridge.RefinedAbstraction;

namespace DoBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor

            customers.Data = new CustomersData();

            // Exercise the bridge

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user

            Console.ReadKey();
        }
    }
}
