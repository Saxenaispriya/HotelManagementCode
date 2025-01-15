using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Booking
    {
        public List<IService> hotelServices = new List<IService>();

        public Booking(string _name,int aadhar,string _roomtype,int bookingid)
        {
            this.name = _name;
            this.aadharnumber = aadhar;
            this.roomType=_roomtype;
            this.bookingID = bookingid;
        }
        public Booking() { }
      
        public int bookingID { get; set; }

        public string name {  get; set; }
        public int aadharnumber { get; set; }
        public string roomType { get; set; }
    }
}
