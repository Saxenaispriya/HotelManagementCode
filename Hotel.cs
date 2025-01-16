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
        public void addSingleRoomInHotel(Room room)
        {
            roomslst.Add(room);
        }
        public void InitRooms()
        {
            int roomNumber = 101;
            for (int i = 0;i <6; i++){
                Room room=null;
                if (i %3 == 0){
                    room = new Room("single",roomNumber);
                }

                if (i % 3 ==1) {
                    room = new Room("double", roomNumber);
                }

                if (i % 3 ==2) {
                    room = new Room("suit", roomNumber);
                }

                roomslst.Add(room);
                room.isRoomAvailable = true;
                roomNumber++;
            }
        }
        public void removeRoomInHotel(int roomnumber)
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
                if (_room.isRoomAvailable.Equals(true))
                {
                    Console.WriteLine("RoomType is:{0} ", _room._roomType);
                    Console.WriteLine("Room Number: {0}", _room._roomNumber);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public bool isRoomAvailableByRoomType(string roomtype)
        {
            foreach (Room _room in roomslst)
            {
                if (_room.isRoomAvailable.Equals(true) && _room._roomType.Equals(roomtype))
                {
                    return true;
                }
            }
            return false;
        }
        public Room getRoomByType(string roomtype)
        {
            Room room = new Room();
            foreach (Room _room in roomslst)
            {
                if (_room.isRoomAvailable.Equals(true) && _room._roomType.Equals(roomtype))
                {
                    room = _room;
                    return _room;
                }
            }
            return room;
        }

        public void checkInRoom(string roomtype)
        {
            Room room;
            room = getRoomByType(roomtype);
            Console.WriteLine("enter your name");
           string name = Console.ReadLine();
            Console.WriteLine("enter aadhar number in digits");
           int aadharnum = Convert.ToInt32(Console.ReadLine());
            Booking booking = new Booking(name,aadharnum, roomtype, room._roomNumber);

            Console.WriteLine("Do you Require Cab Service type yes or no");
            string userChoice = Console.ReadLine();
            if (userChoice == "yes"){
                booking.hotelServices.Add(new cab());
            } 

            Console.WriteLine("Do you Require Food Service type yes or no");
            string useChoice = Console.ReadLine();
            if (userChoice == "yes"){
                booking.hotelServices.Add(new food());
            } 
            
            Console.WriteLine("Do you Require Luggage Service");
            string userPref = Console.ReadLine();
            if (userPref == "yes"){
                booking.hotelServices.Add(new cab());
            } 
            room.isRoomAvailable = false;
        }
        public void vaccantRoom(string roomnumber)
        {
            foreach (Room room in roomslst)
            {
                if (roomnumber.Equals(room._roomNumber))
                {
                    Console.WriteLine("you need to vaccant a Room now");
                    room.isRoomAvailable = false;
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
                    room.isRoomAvailable = true;
                    Console.WriteLine("Room is vaccant: " + room._roomNumber);
                    return;
                }
            }
        }
    }
}
