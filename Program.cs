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

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1. Add Room in Hotel");
                Console.WriteLine("2. Show All Available Room");
                Console.WriteLine("3. Remove Room from Hotel");
                Console.WriteLine("5. Book a Room ");
                Console.WriteLine("6. Vaccant a Room");
                Console.WriteLine("7. exit");

                Console.WriteLine("choose a number and enter accordingly");

                int input;
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        string roomtype,roomnumber;
                        Console.WriteLine("enter room type like single double and suit room");
                        roomtype = Console.ReadLine();
                        Console.WriteLine("enter room number");
                        roomnumber = Console.ReadLine();
                        Room room = new Room(roomtype,roomnumber);
                        hotel.addRoomsInHotel(room);
                        Console.WriteLine("Room is added in Hotel");
                        break;
                    case 2:
                        hotel.showAllAvailableRooms();
                        break;
                    case 3:
                        string roomnNumber;
                        Console.WriteLine("enter room number");
                        roomnNumber = Console.ReadLine();
                        hotel.removeRoomsInHotel(roomnNumber);
                        Console.WriteLine("Room is Removed in Hotel");
                        break;
                    case 5:
                        string room_Type;
                        Console.WriteLine("enter room type like single double and suit room which you want to book");
                        room_Type = Console.ReadLine();
                        Console.WriteLine("Do you require Cab Service type yes or no");
                        string xyz= Console.ReadLine();
                        Console.WriteLine("Do you require Food Service type yes or no");
                        string zyx = Console.ReadLine();

                        hotel.bookRoom(room_Type,xyz,zyx);
                        Console.WriteLine("Room is booked in Hotel");
                        break;
                    case 6:
                        string Roomnumber;
                        Console.WriteLine("enter room number which you want to vaccant");
                        Roomnumber = Console.ReadLine();
                        hotel.vaccantRoom(Roomnumber);
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
