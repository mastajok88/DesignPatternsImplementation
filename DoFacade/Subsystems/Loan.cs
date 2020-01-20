using System;

namespace DoFacade.Subsystems
{
    class Loan
    {
        public bool HasNoBadLoans(Customer.Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
