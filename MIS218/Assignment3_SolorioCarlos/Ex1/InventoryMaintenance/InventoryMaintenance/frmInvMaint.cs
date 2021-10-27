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

		private InvItemList invItems = new InvItemList();

		private void frmInvMaint_Load(object sender, EventArgs e)
		{
            invItems.Changed += new InvItemList.ChangeHandler(HandleChange);
			invItems.Fill();
			FillItemListBox();
		}

		private void FillItemListBox()
		{
            InvItem item;
			lstItems.Items.Clear();
            for (int i = 0; i < invItems.Count; i++)
            {
                item = invItems[i];
                lstItems.Items.Add(item.GetDisplayText());
            }
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			frmNewItem newItemForm = new frmNewItem();
			InvItem invItem = newItemForm.GetNewItem();
			if (invItem != null)
			{
                invItems += invItem;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int i = lstItems.SelectedIndex;
			if (i != -1)
			{
				InvItem invItem = invItems[i];
				string message = "Are you sure you want to delete "
					+ invItem.Description + "?";
				DialogResult button =
					MessageBox.Show(message, "Confirm Delete",
					MessageBoxButtons.YesNo);
				if (button == DialogResult.Yes)
				{
					invItems -= invItem;
				}
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void HandleChange(InvItemList invItems)
        {
            invItems.Save();
            FillItemListBox();
        }
	}
}