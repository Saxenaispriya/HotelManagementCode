using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class PaymentFactory
    {
        public static IPayment GetPayment(string mode)
        {
            IPayment payment=null;
            if (mode=="UPI")
            {
                return new UPI();
            }
            else if (mode == "Debit Card")
            {
                return new DebitCard();
            }
            return payment;
        }
    }
}
