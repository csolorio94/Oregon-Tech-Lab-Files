using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    public interface IPersistable
    {

        void Save(bool[] seats);


        /// <summary>
        /// Loads all seats from persistant storage (database or file)
        /// </summary>
        /// <returns></returns>
        bool[] Fill();
    }
}
