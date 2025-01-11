﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementProjectConsole
{
    internal class Hotel
    {
        List<Room> roomslst = new List<Room>();
        public Hotel() { }
        public void addRoomsInHotel(Room room)
        {
            roomslst.Add(room);
        }
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
        public void bookRoom(string roomtype,string xyz,string zyx)
        {
            bool flag = false;
            double paymoney;
            foreach (Room room in roomslst)
            {
                if (room._roomType.Equals(roomtype) && room.isRoomBooked.Equals(false))
                {
                    if(xyz=="yes")
                    {
                        cab cab = new cab();
                        room._cab = cab;
                    }
                    if (zyx == "yes")
                    {
                        food food = new food();
                        room._food = food;
                    }
                    flag = true;
                    Console.WriteLine("you booked a Room now");
                    room.isRoomBooked = true;
                    Console.WriteLine("Your room number is: {0} ", room._roomNumber);
                    paymoney = room.getPrice();
                    Console.WriteLine("You need to pay money at the time of vaccant: {0}",paymoney);
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
