using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    public interface IReservable : IPersistable
    {
        bool IsFirstClassSeatAvailable(int checkedSeat);

        bool IsEconomyClassSeatAvailable(int checkedSeat);

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

        string[] GetFNames();

        string[] GetENames();

        string[] GetFEmails();

        string[] GetEEmails();

        int[] GetFAge();

        int[] GetEAge();
                
        void EconomyPassengerName(int checkedSeat, string name);

        void FirstPassengerName(int checkedSeat, string name);

        void EconomyAge(int checkedSeat, int age);

        void FirstAge(int checkedSeat, int age);

        void EconomyEmail(int checkedSeat, string email);

        void FirstEmail(int checkedSeat, string email);

        void ResetFirstClass();

        void ResetEconomyClass();

        void ClearCheckboxes();
    }
}

