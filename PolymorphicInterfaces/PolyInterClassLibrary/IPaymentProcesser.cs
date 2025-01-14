using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyInterClassLibrary
{
    public interface IPaymentProcesser
    {
        void ProcessPayment(decimal amount);
    }
}
