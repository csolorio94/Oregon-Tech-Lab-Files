using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    class Reserver : IReservable
    {
        private static int FIRST_CLASS_NUM_SEATS = 5;
        private static int ECONOMY_CLASS_NUM_SEATS = 5;

        private bool[] fseats = new bool[FIRST_CLASS_NUM_SEATS]; //FIRST class seats
        private bool[] eseats = new bool[ECONOMY_CLASS_NUM_SEATS]; //ECONOMY class seats

        public bool IsFirstClassAvailable()
        {
            foreach (var seat in fseats) //using foreach loop
            {
                if (seat == false)
                {
                    return true; //available
                }
            }
            return false; //otherwise unavailable
        }

        //same as first class, just different syntax
        public bool IsEconomyClassAvailable()
        {
            for (int i = 0; i < eseats.Length; i++) //using for loop
            {
                if (eseats[i] == false)
                {
                    return true; //available
                }
            }
            return false; //otherwise unavailable
        }

        private bool[] GetAllFirstSeats()
        {
            return fseats;
        }

        private bool[] GetAllEconomySeats()
        {
            return eseats;
        }

        //should be preceeded with IsFirstClassAvailable to avoid -1
        //returns reserved seat
        public int ReserveFirstClassAnySeat()
        {
            for (int i = 0; i < fseats.Length; i++)
            {
                if (fseats[i] == false)
                {
                    fseats[i] = true;
                    return i; //available seat number
                }
            }
            return -1; //otherwise unavailable
        }

        //should be preceeded with IsEconomyClassAvailable to avoid -1
        //returns reserved seat
        public int ReserveEconomyClassAnySeat()
        {
            for (int i = 0; i < eseats.Length; i++)
            {
                if (eseats[i] == false)
                {
                    eseats[i] = true;
                    return i; //available seat number
                }
            }
            return -1; //otherwise unavailable
        }

        //for displying seats
        public bool[] GetFirstClassSeats()
        {
            return fseats;
        }

        //for displying seats
        public bool[] GetEconomyClassSeats()
        {
            return eseats;
        }

    }
}

