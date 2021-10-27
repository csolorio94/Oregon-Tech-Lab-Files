using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    public interface IReservable
    {
        //returns true if there is available seat in First Class, otherwise, false
        bool IsFirstClassAvailable();

        //returns true if there is available seat in Economy class, otherwise, false
        bool IsEconomyClassAvailable();

        //Reserves first available seat in First Class.
        //returns reserved seat number 
        int ReserveFirstClassAnySeat();

        //Reserves first available seat in Economy Class.
        //returns reserved seat number
        int ReserveEconomyClassAnySeat();

        //Gets array of all first class seats
        bool[] GetFirstClassSeats();

        //Gets array of all economy class seats
        bool[] GetEconomyClassSeats();

    }
}
