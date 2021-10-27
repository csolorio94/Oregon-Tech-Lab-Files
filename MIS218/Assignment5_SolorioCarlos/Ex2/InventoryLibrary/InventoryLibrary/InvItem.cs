using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solorio.Inventory
{
    /// <summary>
    /// Represents an inventory item.
    /// </summary>
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;

        /// <summary>
        /// The default constructor.
        /// </summary>
        public InvItem()
        {
        }

        /// <summary>
        /// A constructor that accepts the values for an item
        /// </summary>
        /// <param name="itemNo">The item's number.</param>
        /// <param name="description">The item's description.</param>
        /// <param name="price">The item's price.</param>
        public InvItem(int itemNo, string description, decimal price)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.price = price;
        }

        /// <summary>
        /// A property that gets and sets the item's number.
        /// </summary>
        public int ItemNo
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

        /// <summary>
        /// A property that gets and sets the item's description.
        /// </summary>
        public string Description
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

        /// <summary>
        /// A property that gets and sets the item's price.
        /// </summary>
        public decimal Price
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

        /// <summary>
        /// A method that formats the item's values for display.
        /// </summary>
        /// <returns>The formatted string</returns>
        public string GetDisplayText()
        {
            return itemNo + "    " + description + " (" + price.ToString("c") + ")";
        }
    }
}
