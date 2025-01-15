using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Room: IHotelService
    {
        IHotelService _service;
        //public List<IHotelService> hotelServices =new List<IHotelService>();
        public Room(string roomtype, int roomnumber)
        {
            _roomType = roomtype;//single bed room, double bed room,suit room
            _roomNumber = roomnumber;
        }
        public Room()
        {

        }
        #region Properties 
        public string _roomType { get; set; }
        public bool isRoomBooked { get; set; } = false;
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
