using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InvItemList
    {
        private List<InvItem> invItems;

        public delegate void ChangeHandler(InvItemList invItems);
        public event ChangeHandler Changed;

        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;

        public InvItem this[int i]
        {
            get
            {
                if (i < 0)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                else if (i > invItems.Count)
                {
                    throw new ArgumentOutOfRangeException(i.ToString());
                }
                return invItems[i];
            }
            set
            {
                invItems[i] = value;
                Changed(this);
            }
        }

        public void Add(InvItem invItem)
        {
            invItems.Add(invItem);
            Changed(this);
        }

        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);
            Changed(this);
        }

        public void Remove(InvItem invItem)
        {
            invItems.Remove(invItem);
            Changed(this);
        }

        public static InvItemList operator +(InvItemList il, InvItem i)
        {
            il.Add(i);
            return il;
        }

        public static InvItemList operator -(InvItemList il, InvItem i)
        {
            il.Remove(i);
            return il;
        }

        public void Fill() => invItems = InvItemDB.GetItems();

        public void Save() => InvItemDB.SaveItems(invItems);
    }
}
