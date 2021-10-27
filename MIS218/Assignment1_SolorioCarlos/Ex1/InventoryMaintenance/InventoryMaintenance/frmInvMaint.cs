using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        // Add a statement here that declares the list of items.
        private List<InvItem> invitems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
           
            // Add a statement here that gets the list of items.
            invitems = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            // Add code here that loads the list box with the items in the list.
            lstItems.Items.Clear();
            foreach (InvItem i in invitems)
            {
                lstItems.Items.Add(i.GetDisplayText("\t"));
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invitem = newItemForm.GetItem();
            if (invitem != null)
            {
                invitems.Add(invitem);
                InvItemDB.SaveItems(invitems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                InvItem invitem = (InvItem)invitems[i];
                string message = "Are you sure you want to delete "
                     + invitem.Description + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    invitems.Remove(invitem);
                    InvItemDB.SaveItems(invitems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


