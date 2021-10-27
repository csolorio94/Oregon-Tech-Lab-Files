using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItem
    {
        public int ItemNo;
        public string Description;
        public decimal Price;

        public InvItem() { }

        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

        public int itemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }

        public string description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public decimal price
        {
            get
            {
             return price;
            }
            set
            {
             price = value;
            }
        }


        public string GetDisplayText(string sep)
        {
            return ItemNo + sep + Price.ToString("c") + sep + Description;
        }



    }
}


