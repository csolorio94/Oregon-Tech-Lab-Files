using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class Product
	{
		private string code;
		private string description;
		private decimal price;

		public Product() { }

		public Product(string code, string description, decimal price)
		{
			this.Code = code;
			this.Description = description;
			this.Price = price;
		}

		public string Code
		{
			get
			{
				return code;
			}
			set
			{
				code = value;
			}
		}

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

        public string GetDisplayText()
        {
            return code + ", " + price.ToString("c") + ", " + description;
        }

		public string GetDisplayText(string sep)
		{
			return code + sep + price.ToString("c") + sep + description;
		}
	}
}
