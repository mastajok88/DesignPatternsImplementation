using System;

namespace DoFacade.Subsystems
{
    class Bank
    {
        public bool HasSufficientSavings(Customer.Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
