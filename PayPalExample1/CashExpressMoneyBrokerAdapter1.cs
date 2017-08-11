using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalExample1
{
    public class CashExpressMoneyBrokerAdapter1 : IPaymentAdapter
    {
        private CashExpressMoneyBroker CashExpressMoneyBroker { get; set; }
        public CashExpressMoneyBrokerAdapter1(CashExpressMoneyBroker cashexpressMoneyBroker)
        {
            this.CashExpressMoneyBroker = cashexpressMoneyBroker;
        }
        public void Pay(double amount)
        {
            this.CashExpressMoneyBroker.DoPayment(amount);
        }
    }
}
