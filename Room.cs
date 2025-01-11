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
         
        public double getRoomPrice()
        {
           switch(_roomType)
            {
                case "single":
                    return 2000;
                case "double":
                    return 4000;
                case "suit":
                    return 5000;
                default:
                    return 1000;
            }
        }

        public double getPrice()
        {
            double sum = 0;
            if (_food!=null)
            {
                sum = sum + _food.servicePrice;
            }
            if (_cab!=null)
            {
                sum = sum + _cab.servicePrice;
            }
            sum= sum+getRoomPrice();
            return sum;
        }
        #endregion
    }
}
