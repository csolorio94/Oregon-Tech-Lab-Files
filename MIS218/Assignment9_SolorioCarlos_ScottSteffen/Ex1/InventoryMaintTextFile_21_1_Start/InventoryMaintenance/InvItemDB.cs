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
        private const string Path = @"..\..\InventoryItems.txt";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // Add code here to read the text file into the List<InvItem> object.
            StreamReader textIn = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                InvItem item = new InvItem();
                item.ItemNo = Convert.ToInt32(columns[0]);
                item.Description = columns[1];
                item.Price = Convert.ToDecimal(columns[2]);
                items.Add(item);
            }

            textIn.Close();
            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a text file.
            StreamWriter textOut = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
            
            foreach (InvItem item in items)
            {
                textOut.Write(item.ItemNo + "|");
                textOut.Write(item.Description + "|");
                textOut.WriteLine(item.Price);
            }
            
            textOut.Close();
        }
    }
}

