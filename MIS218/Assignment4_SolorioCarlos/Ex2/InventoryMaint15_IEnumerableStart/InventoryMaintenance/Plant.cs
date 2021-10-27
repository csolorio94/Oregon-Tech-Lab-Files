using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Plant : InvItem
    {
        private string size;

        public Plant()
        {
        }

        public Plant(int itemNo, string description, decimal price, string size) :
            base(itemNo, description, price)
        {
            this.size = size;
        }

        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }

        public override string GetDisplayText()
        {
            return this.ItemNo + "    " + this.Size + " " + this.Description +
                " (" + this.Price.ToString("c") + ")";
        }
    }
}
