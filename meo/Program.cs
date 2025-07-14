namespace meo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Payment[] payments = new Payment[4];

            payments[0] = new CreditCardPayment(100.0, "1234");
            payments[1] = new CashPayment(9.0);
            payments[2] = new CreditCardPayment(200.0, "1111");
            payments[3] = new CashPayment(10.0);

            foreach (var payment in payments)
            {
                payment.ProcessPayment();
            }
        }
    }
}
