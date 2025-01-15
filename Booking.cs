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
        public List<IHotelService> hotelServices = new List<IHotelService>();

        public Booking(string _name,int aadhar,string _roomtype)
        {
            this.name = _name;
            this.aadharnumber = aadhar;
            this.roomType=_roomtype;
        }
        public Booking() { }
        public bool isBookedRoomAvailable(string roomtype)
        {
            List<Room> roomlist = new List<Room>();
            bool flag = false;
            foreach (Room _room in roomlist)
            {
                if (_room.isRoomBooked.Equals(false) && _room._roomType.Equals(roomtype))
                {
                    return true;
                }
            }
            return flag; 
        }

        public Room getVaccantRoom(string roomtype)
        {
            List<Room> roomlist = new List<Room>();
            Room room = new Room();
            foreach (Room _room in roomlist)
            {
                if (_room.isRoomBooked.Equals(false) && _room._roomType.Equals(roomtype))
                {
                    return _room;
                }
            }
            return room;
        }
        public int bookingID { get; set; }

        public string name {  get; set; }
        public int aadharnumber { get; set; }
        public string roomType { get; set; }
    }
}
