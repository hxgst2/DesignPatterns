using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalExample1
{
    public class PayPalAdapter1:IPaymentAdapter
    {
        private PayPal PayPal { get; set; }
        public PayPalAdapter1(PayPal payPal)
        {
            this.PayPal = payPal;

        }

        public void Pay(double amount)
        {
            // this.PayPal.SendPayment(amount);
            this.PayPal.PayPayment(amount);
        }
    }
}
