using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    public interface IPayment
    {
        double paymentAmount(double amount);
    }
}
