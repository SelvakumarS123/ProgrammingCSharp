using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInterClassLibrary
{
    public class PayPalProcesser : IPaymentProcesser //PayPalProcesser is implementing the IPaymentProcesser interface
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("processing pp for amount " + amount);
        }
    }
}
