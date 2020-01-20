using System;

using DoFacade.Facade;

namespace DoFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade

            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer

            Customer.Customer customer = new Customer.Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user

            Console.ReadKey();
        }
    }
}
