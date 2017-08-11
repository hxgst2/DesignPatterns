using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPalExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Without Adapter
            Print($"Results without Adapter, Using PayPal Object directly with SendPayment");
            PayPal paypalWithoutAdapter1 = new PayPal();
            paypalWithoutAdapter1.SendPayment(560.90D);

            PayPal paypalWithoutAdapter2 = new PayPal();
            paypalWithoutAdapter2.SendPayment(60.90D);

            PayPal paypalWithoutAdapter3 = new PayPal();
            paypalWithoutAdapter3.SendPayment(50.90D);

            // Now PayPal changes SendPayment method to PayAmount
            // You need to go back to all code and change "SendPayment" method to "PayPayment"
            // Without Adapter    
            Print($"Results without Adapter, Using PayPal Object directly with PayPayment");
            paypalWithoutAdapter1.PayPayment(560.90D);            
            paypalWithoutAdapter2.PayPayment(60.90D);            
            paypalWithoutAdapter3.PayPayment(50.90D);

            // Solution to above problem to add Adapter around PayPal Class and Use it
            // Below Code Used SendPayment method
            Print($"Results with Adapter using SendPayment");
            PayPalAdapter1 paypalAdapter1 = new PayPalAdapter1(paypalWithoutAdapter1);
            paypalAdapter1.Pay(560.90D);
            paypalAdapter1 = new PayPalAdapter1(paypalWithoutAdapter2);
            paypalAdapter1.Pay(60.90D);
            paypalAdapter1 = new PayPalAdapter1(paypalWithoutAdapter3);
            paypalAdapter1.Pay(50.90D);

            // Now Paypal Changes it's "SendPayment" method to "PayPayment"
            // all we have to do it, go in Adapter Class and Change Method name to "PayPayment"
            // Below code uses PayAmount method
            Print($"Results with Adapter using PayPayment");
            paypalAdapter1 = new PayPalAdapter1(paypalWithoutAdapter1);
            paypalAdapter1.Pay(560.90D);
            paypalAdapter1 = new PayPalAdapter1(paypalWithoutAdapter2);
            paypalAdapter1.Pay(60.90D);
            paypalAdapter1 = new PayPalAdapter1(paypalWithoutAdapter3);
            paypalAdapter1.Pay(50.90D);


            // Wait here to view Output
            Console.ReadLine();

        }

        private static void Print(string strValue)
        {
            Console.WriteLine(strValue);
        }
    }
}
