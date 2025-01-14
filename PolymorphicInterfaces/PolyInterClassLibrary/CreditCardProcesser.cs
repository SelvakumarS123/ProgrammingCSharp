namespace PolyInterClassLibrary
{
    public class CreditCardProcesser : IPaymentProcesser //implemets and processes creditCard Payments.
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("processing cc for amount " + amount);
        }
    }
}
