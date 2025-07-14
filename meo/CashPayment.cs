using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meo
{
    internal class CashPayment : Payment
    {
        public CashPayment(double amount) : base(amount)
        {
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing cash payment of {Amount}");
        }
    }
}
