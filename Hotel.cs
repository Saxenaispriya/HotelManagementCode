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

        public void createBooking()//name change create room
        {
             int j = 101;
            for(int i=0;i<2;i++)
            {
                Room room = new Room("single",j);
                room.isRoomBooked = true;
                roomslst.Add(room);
                j++;
            }
            for (int i = 0; i < 2; i++)
            {
                Room room = new Room("double", j);
                room.isRoomBooked = true;
                roomslst.Add(room);
                j++;
            }
            for (int i = 0; i < 2; i++)
            {
                Room room = new Room("suit", j);
                room.isRoomBooked = true;
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
                if (_room.isRoomBooked.Equals(true))
                {
                    Console.WriteLine("RoomType is:{0} ", _room._roomType);
                    Console.WriteLine("Room Number: {0}", _room._roomNumber);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public bool isBookedRoomAvailable(string roomtype)
        {
            //List<Room> roomlist = new List<Room>();
            bool flag = false;
            foreach (Room _room in roomslst)
            {
                if (_room.isRoomBooked.Equals(true) && _room._roomType.Equals(roomtype))
                {
                    return true;
                }
            }
            return flag;
        }
        public Room getroombytype(string roomtype)
        {
            //List<Room> roomlist = new List<Room>();
            Room room = new Room();
            foreach (Room _room in roomslst)
            {
                if (_room.isRoomBooked.Equals(true) && _room._roomType.Equals(roomtype))
                {
                    room = _room;
                    return _room;
                }
            }
            return room;
        }
        public void checkInRoom(string xyz,string zyx,string zyy, Booking booking,Room room)//added in list
        {
            bool flag = false;
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
                     booking.hotelServices.Add(room);
                     booklst.Add(booking);
                     flag = true;
                    Console.WriteLine("you booked a Room");
            Console.WriteLine("your room number is:" + room._roomNumber + " ");

            //room.isRoomBooked = true;
            //Console.WriteLine("Your room number is: {0} ", room._roomNumber);
            //paymoney = room.getPrice();
            //Console.WriteLine("You need to pay money at the time of vaccant: {0}",paymoney);

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
        public void checkoutRoom(int bookingid)
        {
            
            double sum = 0;
            foreach(Booking booking in booklst)
            {
                if(booking.bookingID.Equals(bookingid))
                {
                    foreach(IService service in booking.hotelServices)
                    {
                        sum=sum+service.getServicePrice();
                    }
                }
            }
            Console.WriteLine("you will pay amount:" + sum);
            foreach (Room room in roomslst)
            {
                if (bookingid.Equals(room._roomNumber))
                {
                    room.isRoomBooked = true;
                    Console.WriteLine("you need to vaccant a Room now");
                    room.isRoomBooked = true;
                    Console.WriteLine("Room is Available: " + room._roomNumber);
                    break;
                }
            }
        }
    }
}
