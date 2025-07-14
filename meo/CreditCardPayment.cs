using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meo
{
    internal class CreditCardPayment: Payment
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(double amount, string cardNumber)
            : base(amount)
        {
            CardNumber = cardNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {Amount} using card {CardNumber}");
        }
    }
}
