using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void invoicesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.invoicesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.InvoiceLineItems' table. You can move, or remove it, as needed.
            //this.invoiceLineItemsTableAdapter.Fill(this.mMABooksDataSet.InvoiceLineItems);
            // TODO: This line of code loads data into the 'mMABooksDataSet.Invoices' table. You can move, or remove it, as needed.
            //this.invoicesTableAdapter.Fill(this.mMABooksDataSet.Invoices);
            GridViewFormatter(); //Formats the grid view properly.
            

        }

        private void fillByInvoiceIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // this.invoicesTableAdapter.FillByInvoiceID(this.mMABooksDataSet.Invoices, ((int)(System.Convert.ChangeType(invoiceIDToolStripTextBox.Text, typeof(int))))); Generated Code.
                int invoiceID = Convert.ToInt32(invoiceIDToolStripTextBox.Text);

                this.invoicesTableAdapter.FillByInvoiceID(this.mMABooksDataSet.Invoices, invoiceID);
                this.invoiceLineItemsTableAdapter.Fill(this.mMABooksDataSet.InvoiceLineItems);

                if (invoiceLineItemsBindingSource.Count == 0)
                    MessageBox.Show("No invoice found. " + "Please search again.", "Invoice not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            
        }

        private void GridViewFormatter()
        {
            this.dataGridViewTextBoxColumn3.DefaultCellStyle.Format = "c";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle.Format = "c";
        }
    }
}
