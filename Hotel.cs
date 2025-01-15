using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Hotel
    {
       public List<Room> roomslst = new List<Room>();
       public List<Booking> booklst = new List<Booking>();
        public Hotel() { }
        public void addRoomsInHotel(Room room)
        {
            roomslst.Add(room);
        }

        public void createBooking()
        {  
            for(int i=0;i<2;i++)
            {
                int j = 101;
                Room room = new Room("single",j);
                roomslst.Add(room);
                j++;
            }
            for (int i = 0; i < 2; i++)
            {
                int j = 103;
                Room room = new Room("double", j);
                roomslst.Add(room);
                j++;
            }
            for (int i = 0; i < 2; i++)
            {
                int j = 105;
                Room room = new Room("suit", j);
                roomslst.Add(room);
                j++;
            }
        }
        //add room room type number of room
        public void removeRoomsInHotel(string roomnumber)
        {
            for (int i = 0; i < roomslst.Count; i++)
            {
                if (roomnumber.Equals(roomslst[i]._roomNumber))
                {
                    roomslst.RemoveAt(i);
                }
            }
        }
        public void showAllAvailableRooms()
        {
            if (roomslst.Count == 0)
            {
                Console.WriteLine("No Rooms Added!!!");
                return;
            }
            foreach (Room _room in roomslst)
            {
                if (_room.isRoomBooked.Equals(false))
                {
                    Console.WriteLine("RoomType is:{0} ", _room._roomType);
                    Console.WriteLine("Room Number: {0}", _room._roomNumber);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        public void checkInRoom(string roomtype,string xyz,string zyx,string zyy,Room _room)//added in list
        {
            bool flag = false;
            double paymoney;
            foreach (Booking booking in booklst)
            {
                if (_room._roomType.Equals(roomtype) && _room.isRoomBooked.Equals(false))
                {
                    if(xyz=="yes")
                    {
                        cab cab = new cab();
                        booking.hotelServices.Add(cab);
                    }
                    if (zyx == "yes")
                    {
                        food food = new food();
                        booking.hotelServices.Add(food);
                    }
                    if (zyy == "yes")
                    {
                        LuggageService luggageService = new LuggageService();
                        booking.hotelServices.Add(luggageService); 
                    }
                    //flag = true;
                    //Console.WriteLine("you booked a Room now");
                    //room.isRoomBooked = true;
                    //Console.WriteLine("Your room number is: {0} ", room._roomNumber);
                    //paymoney = room.getPrice();
                    //Console.WriteLine("You need to pay money at the time of vaccant: {0}",paymoney);
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("All Rooms is booked");
            }
        }
        public void vaccantRoom(string roomnumber)
        {
            foreach (Room room in roomslst)
            {
                if (roomnumber.Equals(room._roomNumber))
                {
                    Console.WriteLine("you need to vaccant a Room now");
                    room.isRoomBooked = false;
                    Console.WriteLine("Room is Available: ", roomnumber);
                    break;
                }
            }
        }
    }
}
