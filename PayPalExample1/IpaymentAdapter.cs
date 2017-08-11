using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalExample1
{
    interface IPaymentAdapter
    {
        void Pay(double amount);
    }
}
