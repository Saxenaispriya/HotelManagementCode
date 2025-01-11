using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Room
    {
        public Room(string roomtype,string roomnumber) 
        { 
            _roomType = roomtype;//single bed room, double bed room,suit room
            _roomNumber = roomnumber;
        }
        public Room()
        {

        }
        #region Properties 
        public string _roomType {  get; set; }
        public bool  isRoomBooked {  get; set; }=false;
        public string _roomNumber { get; set; }
        public double _roomPrice {  get; set; }
        public food _food { get; set; }
        public cab _cab { get; set; }
        #endregion

        #region Methods
         
        public double getRoomPrice(string roomtype)
        {
            Room room = new Room();
            if(roomtype=="single")
            {
                room._roomPrice = 2000;
            }
            else if(roomtype=="double")
            {
                room._roomPrice = 4000;
            }
            else
            {
                room._roomPrice = 5000;
            }
           return room._roomPrice;
        }

        public double getServicePrice(string servicename)
        {
            food food = new food();
            cab cab = new cab();
            if (servicename == "food")
            {
               food.servicePrice = 3000;
                return food.servicePrice;
            }
            else if (servicename =="cab")
            {
                cab.servicePrice = 2500;
                return cab.servicePrice;
            }
            else
            {
                return 0.00;
            }
        }
        #endregion
    }
}
