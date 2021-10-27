using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoLargestNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Code structure help from Daniel Salgado


        int[] numbers = new int[10];
        int counter = 0;
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    numbers[counter] = Convert.ToInt32(numBox.Text);
                    counter++;
                    numBox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
            finally
            {
                recentLbl.Text = "Number of Entries (Max 10): " + Convert.ToString(counter);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            foreach (int i in numbers)
            {
                if (i > largest)
                {
                    secondLargest = largest;
                    largest = i;
                }

                else if (i > secondLargest)
                {
                    secondLargest = i;
                }

            }

            largestLbl.Text = "The Largest Number is: " + Convert.ToString(largest);
            secLargestLbl.Text = "The Second Largest Number is: " + Convert.ToString(secondLargest);

        }

        public bool IsValidData()
        {
            if (!IsPresent())
                return false;
            if (!IsInt32())
                return false;
            
          return true;
        }

        public bool IsPresent()
        {
            if (numBox.Text == "")
            {
                MessageBox.Show("Please enter a Number.", "Entry Error");
                this.Focus();
                return false;
            }
            return true;

        }

        public bool IsInt32()
        {
            int number = 0;
            if (int.TryParse(numBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Number must be an integer value.", "Entry Error");
                return false;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numbers = new int[10];
            counter = 0;
            numBox.Text = "";
            recentLbl.Text = "Number of Entries (Max 10):" + Convert.ToString(counter);
            largestLbl.Text = "The Largest Number is: 0";
            secLargestLbl.Text = "The Second Largest Number is: 0";
            numBox.Focus();
        }
        
        
    }
}
    

