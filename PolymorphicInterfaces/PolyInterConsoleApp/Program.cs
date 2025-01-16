using PolyInterClassLibrary;

namespace PolyInterConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IPaymentProcesser creditCardProcesser = new CreditCardProcesser();//polymorphism-> treating the CreditCardProcessor like an IPaymentProcessor.
            PaymentService paymentService = new PaymentService(creditCardProcesser); //processing orderpayment with creditcard
            paymentService.ProcessOrderPayment(100.00m); 

            IPaymentProcesser payPalProcesser = new PayPalProcesser(); //using a single interface(IPaymentProcessor) to create objects of 2 different classes-inheritance
            paymentService = new PaymentService(payPalProcesser); //code is the same, the only difference is the parameter passed to the PaymentService Costructor
            paymentService.ProcessOrderPayment(200.00m);
        }

        //here we have a single class -> PaymentService -> that accepts any type of paymentProcessor(credit or paypal etc), as long as they implement the same interface
        //DeCoupling:
        //->By decoupling, you can switch between CreditCardProcessor and PayPalProcessor without changing the PaymentService logic.
        //->easily switch between the ProcessPayment mechanisms without changing the the PaymentService.
    }
}
