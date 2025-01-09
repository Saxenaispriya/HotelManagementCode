using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Hotel
    {
        List<Room> roomslst=new List<Room>();
        public Hotel() { }
        public void addRoomsInHotel(Room room)
        {
            roomslst.Add(room);
        }
        public void removeRoomsInHotel(Room room)
        {
            roomslst.Remove(room);
        }
        public void showAllAvailableRooms()
        {
           // int i = 0;
            foreach(Room _room in roomslst)
            {
                if(_room.isRoomBooked.Equals(false))
                {
                    
                    Console.WriteLine("RoomType is:{0} ", _room._roomType);
                   // Console.WriteLine("Room Number is: ", _room._roomNumber[i]);
                   // i++;
                }
            }
            Console.WriteLine();
        }
        public void bookRoom(string roomtype)
        {
            // int i = 0;
            bool flag = false;
            foreach (Room room in roomslst)
           {
                if(room._roomType.Equals(roomtype) && room.isRoomBooked.Equals(false))
                {
                    flag = true;
                    Console.WriteLine("you booked a Room now");
                    room.isRoomBooked = true;
                   // Console.WriteLine("Your room number is: ", room._roomNumber[i]);
                   // i++;
                    break;
                }
           }
           if(flag==false)
            {
                Console.WriteLine("All Rooms is booked");
            }
        }
        public void vaccantRoom(string roomtype,string roomnumber)
        {
            foreach (Room room in roomslst)
            {
                if (room._roomType.Equals(roomtype) && room.isRoomBooked.Equals(true))
                {
                    Console.WriteLine("you need to vaccant a Room now");
                    room.isRoomBooked = false;
                    Console.WriteLine("Your room number is: ", roomnumber);
                    break;
                }
            }
        }
    }
}
