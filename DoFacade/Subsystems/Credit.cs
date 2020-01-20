using System;

namespace DoFacade.Subsystems
{
    class Credit
    {
        public bool HasGoodCredit(Customer.Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }
}
