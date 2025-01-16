using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Room: IService
    {
        IService _service;
    
        public Room(string roomtype, int roomnumber)
        {
            _roomType = roomtype;//single bed room, double bed room,suit room
            _roomNumber = roomnumber;
            switch (_roomType)
            {
                case "single":
                    _roomPrice= 2000;
                    break;
                case "double":
                    _roomPrice= 4000;
                    break;
                case "suit":
                    _roomPrice= 5000;
                    break;
                default:
                    _roomPrice=  1000;
                    break;
            }
        }
        public Room()
        {

        }
        #region Properties 
        public string _roomType { get; set; }
        public bool isRoomAvailable { get; set; } = false;
        public int _roomNumber { get; set; }
        public double _roomPrice { get; set; }

        public double getServicePrice()
        {
            switch (_roomType)
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

        #endregion

        #region Methods

        //public double getRoomPrice() 
        //{
        //   switch(_roomType)
        //    {
        //        case "single":
        //            return 2000;
        //        case "double":
        //            return 4000;
        //        case "suit":
        //            return 5000;
        //        default:
        //            return 1000;
        //    }
        //}

        //public double getPrice()
        //{
        //    double sum = 0;

        //    foreach(IHotelService hotelService in hotelServices)
        //    {
        //      sum=sum+hotelService.getRoomPrice();
        //    }
        //    sum= sum+getRoomPrice();
        //    return sum;
        //}
        #endregion
    }
}
