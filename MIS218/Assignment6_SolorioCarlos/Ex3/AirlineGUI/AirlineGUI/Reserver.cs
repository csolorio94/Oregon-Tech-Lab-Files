using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Main GUI
/// </summary>
namespace AirlineGUI
{
    public class Reserver : IReservable, IPersistable
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

        //Checks if a specific first seat is availble.
        public bool IsFirstClassSeatAvailable(int checkedSeat)
        {
            if (fseats[checkedSeat] == false)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Reserves First Class
        /// </summary>
        //Reserves a specific first seat.
        public void ReserveFirstClassSeat(int checkedSeat)
        {
            fseats[checkedSeat] = true; // reserve the checked seat
        }

        /// <summary>
        /// Unreserves First Class
        /// </summary>
        //UnReserve a specific first seat.
        public void UnReserveFirstClassSeat(int checkedSeat)
        {
            fseats[checkedSeat] = false; // reserve the checked seat
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
        //Checks if a specific seat is avavilble.
        public bool IsEconomyClassSeatAvailable(int checkedSeat)
        {
            if (eseats[checkedSeat] == false)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Suppose to Reserve Specific Economy Seat
        /// </summary>
        //Reserves a specific economy seat.
        public void ReserveEconomyClassSeat(int checkedSeat)
        {
            eseats[checkedSeat] = true; // reserve the checked seat
        }

        /// <summary>
        /// Suppose to UnReserve Specific Economy Seat
        /// </summary>
        public void UnReserveEconomyClassSeat(int checkedSeat)
        {
            eseats[checkedSeat] = false; // reserve the checked seat
        }

        private bool[] GetAllFirstSeats()
        {
            return fseats;
        }

        private bool[] GetAllEconomySeats()
        {
            return eseats;
        }

        
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

        /// <summary>
        /// Removes any current reserved seats
        /// </summary>
        public void ClearCheckboxes()
        {
            Array.Clear(fseats, 0, fseats.Length);
            Array.Clear(eseats, 0, eseats.Length);
        }

        public void Save(String file, bool[] seats)
        {

        }

        public void Load(String filename, bool[] seats)
        {

        }

    }
}
