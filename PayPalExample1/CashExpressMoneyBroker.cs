using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalExample1
{
    /// <summary>
    /// This is Third Party Component
    /// </summary>
    public class CashExpressMoneyBroker
    {
        public CashExpressMoneyBroker()
        {

        }
       
        public void DoPayment(double amount)
        {
            Console.WriteLine($"CashExpressMoneyBroker via DoPayment: ${amount}");
        }
    }
}
