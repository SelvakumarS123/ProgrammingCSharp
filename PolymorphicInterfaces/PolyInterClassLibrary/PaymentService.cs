using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInterClassLibrary
{
    public class PaymentService
    {
        private readonly IPaymentProcesser _processer;

        public PaymentService(IPaymentProcesser processer) //just pass me a class that implements the IPaymentProcesser Interface
        {
            _processer = processer;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processer.ProcessPayment(amount); // hey _processor, I know that you have this method called ProcessPayment(because you're following the blueprint of IPaymentProcessor Interface),
                                               // and now depending on what kind of processor you are, use your way of implementing.
                                                
        //ProcessPayment logic is defined inside of the "_processor".
        //the "_processor" is whoever we pass into the PaymentService constructor(ccp or ppp)
                                                 
        }
    }
}
