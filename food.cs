using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class food:IService
    {
        public string serviceName { get; set; }
        public double servicePrice {  get; set; }

        public food()
        {
            serviceName = "food";
            servicePrice = 5000;
        }

        public double getServicePrice()
        {
            return servicePrice;
        }
    }
}
