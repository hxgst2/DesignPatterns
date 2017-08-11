using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalExample1
{
    public class PayPal
    {
        public PayPal()
        {

        }

        public void SendPayment(double amount)
        {
            Console.WriteLine($"Paying via PayPal: ${amount}");
        }

        public void PayPayment(double amount)
        {
            Console.WriteLine($"Paying via PayPal: ${amount}");
        }
    }
}
