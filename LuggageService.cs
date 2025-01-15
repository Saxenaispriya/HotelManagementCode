using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class LuggageService : IService
    {
        public string serviceName { get; set; }
        public double servicePrice { get; set; }
        public LuggageService() {
            serviceName = "luggage";
            servicePrice = 4000;
        }
        public double getServicePrice()
        {
           return servicePrice;
        }
        
    }
}
