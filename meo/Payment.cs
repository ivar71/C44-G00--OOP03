using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meo
{
    internal class Payment
    {
        public double Amount { get; set; }

        public Payment(double amount)
        {
            Amount = amount;
        }

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount}.");
        }
    }
}
