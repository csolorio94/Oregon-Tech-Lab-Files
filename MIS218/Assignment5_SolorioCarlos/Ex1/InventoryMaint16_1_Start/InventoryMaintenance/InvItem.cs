using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    /// <summary>
    /// InvItem class
    /// </summary>
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;

        /// <summary>
        /// Creates a InvItem Class object with default values.
        /// </summary>
        public InvItem()
        {
        }

        /// <summary>
        /// Creates a InvItem object with the specified values.
        /// </summary>
        /// <param name="itemNo">The item number to be stored in the object.</param>
        /// <param name="description">The description to be stored in the object.</param>
        /// <param name="price">The price to be stored in the object.</param>

        public InvItem(int itemNo, string description, decimal price)
        {
            this.itemNo = itemNo;
            this.description = description;
            this.price = price;
        }

        /// <summary>
        /// Gets or sets the item number.
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
        /// Gets or sets the description.
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
        /// Gets or sets the price.
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
        /// Concatenates the item number, descriptiion, and price for display.
        /// </summary>
        /// <returns>The formatted string.</returns>
        public string GetDisplayText()
        {
            return itemNo + "    " + description + " (" + price.ToString("c") + ")";
        }
    }
}
