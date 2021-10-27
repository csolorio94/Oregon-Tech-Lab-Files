using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    public interface IPersistable
    {

        /// <summary>
        /// Persist seats in File or Database
        /// </summary>        
        void Save();

        void SavePassengers();

        /// <summary>
        /// Loads all seats from persistant storage (database or file)
        /// </summary>
        /// <returns></returns>
        bool[] Fill();

        void LoadPassenger();
    }
}
