using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solorio.Airline
{
    public interface IReservable
    {
        //returns true if at least one seat is available in First class
        bool IsFirstClassAvailable();

        //returns true if at least one seat is available in Economy class
        bool IsEconomyClassAvailable();

        ///returns assigned first  available(!) seat number in First class
        int ReserveFirstClassAnySeat();

        ///returns assigned first available(!) seat number in Economy class
        int ReserveEconomyClassAnySeat();

        ///assigns specific seat number in First class
        void ReserveFirstClassSeat(int seat);

        ///assigns specific seat number in Economy class
        void ReserveEconomyClassSeat(int seat);

        ///un-assigns specific seat number in First class
        void UnReserveFirstClassSeat(int seat);

        ///un-assigns specific seat number in Economy class
        void UnReserveEconomyClassSeat(int seat);

        ///gets all seats assigned and un-assigned in First class
        bool[] GetFirstClassSeats();

        ///gets all seats assigned and un-assigned in Economy class
        bool[] GetEconomyClassSeats();
    }
}

