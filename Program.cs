using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.InitRooms();

            bool exit = true;
            while (exit)
            {
                // Console.WriteLine("1. Add Room in Hotel");
                Console.WriteLine("2. Show All Available Room");
                Console.WriteLine("3. Remove Room from Hotel");
                Console.WriteLine("5. Book a Room ");
                Console.WriteLine("6. Checkout Room");
                Console.WriteLine("7. exit");

                Console.WriteLine("choose a number and enter accordingly");

                int input;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    //case 1:
                    //    string roomtype; int roomnumber;
                    //    Console.WriteLine("enter room type like single double and suit room");
                    //    roomtype = Console.ReadLine();
                    //    Console.WriteLine("enter room number");
                    //    roomnumber = Convert.ToInt32(Console.ReadLine());
                    //    Booking room = new BookingRoom(roomtype, roomnumber);
                    //    hotel.addSingleRoomInHotel(room);
                    //    Console.WriteLine("Room is added in Hotel");
                    //    break;
                    case 2:
                        hotel.showAllAvailableRooms();
                        break;
                    case 3:
                        int roomnNumber;
                        Console.WriteLine("enter room number");
                        roomnNumber =Convert.ToInt32(Console.ReadLine());
                        hotel.removeRoomInHotel(roomnNumber);
                        Console.WriteLine("Room is Removed in Hotel");
                        break;
                    case 6:
                        int Roomnumber;
                        Console.WriteLine("enter room number which you want to vaccant");
                        Roomnumber = Convert.ToInt32(Console.ReadLine());
                        hotel.checkoutRoom(Roomnumber);
                        break;
                    case 5:
                        Console.WriteLine("enter which room do you want");
                        string _roomType = Console.ReadLine();
                        bool available = hotel.isRoomAvailableByRoomType(_roomType);
                        if (!available)
                        {
                            Console.WriteLine("No room avaialble");
                            return;
                        }
                        hotel.checkInRoom(_roomType);
                        break;
                    case 7:
                        exit = false;
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
