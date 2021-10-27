using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"..\..\InventoryItems.dat";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // Add code here to read the binary file into the List<InvItem> object.
            BinaryReader binaryIn = new BinaryReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            while (binaryIn.PeekChar() != -1)
            {
                InvItem i = new InvItem();
                i.ItemNo = (binaryIn.ReadInt32());
                i.Description = binaryIn.ReadString();
                i.Price = Convert.ToDecimal(binaryIn.ReadDecimal());
                items.Add(i);
            }

            binaryIn.Close();
            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            BinaryWriter binaryOut = new BinaryWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (InvItem i in items)
            {
                binaryOut.Write(i.ItemNo);
                binaryOut.Write(i.Description);
                binaryOut.Write(i.Price);
            }

            binaryOut.Close();

        }
    }
}
