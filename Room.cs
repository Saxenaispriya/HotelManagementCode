using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Room
    {
       public List<string> _roomNumber=new List<string>();
        public Room(string roomtype,string roomnumber) 
        { 
            _roomType = roomtype;//single bed room, double bed room,suit room
            _roomNumber.Add(roomnumber);
        }
        public Room()
        {

        }
        public string _roomType {  get; set; }
        public bool  isRoomBooked {  get; set; }=false;
    }
}
