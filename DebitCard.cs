using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class DebitCard:IPayment
    {
        public double paymentAmount(double amount)
        {
            return amount;
        }
    }
}
