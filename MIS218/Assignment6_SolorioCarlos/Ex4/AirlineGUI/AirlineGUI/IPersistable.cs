using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineGUI
{
    public interface IPersistable
    {
        //Saves first class and economy (as a singe array) in a file
        void Save(String fileName, bool[] seats);

        //Loads first class and economy (as a single array) from a file
        void Load(String fileName, bool[] seats);
    }
}
