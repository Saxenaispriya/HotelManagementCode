﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class cab:IService
    {
        public string serviceName { get; set; } 
        public double servicePrice {  get; set; }

        public cab() {
            servicePrice = 2000;
            serviceName = "cab";
        }

        public double getServicePrice()
        {
           return servicePrice;
        }
    }
}
