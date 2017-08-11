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
    public class PayPal
    {
        public PayPal()
        {

        }

        public void SendPayment(double amount)
        {
            Console.WriteLine($"Paying via SendPayment: ${amount}");
        }

        public void PayPayment(double amount)
        {
            Console.WriteLine($"Paying via PayPayment: ${amount}");
        }
    }
}
