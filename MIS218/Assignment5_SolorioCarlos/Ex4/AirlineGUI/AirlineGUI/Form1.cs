using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solorio.Airline;

namespace AirlineGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Reserver r = new Reserver();
        string totalSeats = " of 5";

        private void Form1_Load_1(object sender, EventArgs e)
        {

            //foreach (Control control in groupBoxFirst.Controls)
            //{
            //    if (control.GetType() == typeof(CheckBox))
            //    {
            //        ((CheckBox)control).CheckedChanged += new EventHandler(this.CheckChanged_click);
            //    }
            //}

            //foreach (Control control in groupBoxEconomy.Controls)
            //{
            //    if (control.GetType() == typeof(CheckBox))
            //    {
            //        ((CheckBox)control).CheckedChanged += new EventHandler(this.CheckChanged_click);
            //    }
            //}
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {

            if (radioButtonFirst.Checked) //Check if first class

            {
                // First class radio button

                if (r.IsFirstClassAvailable())
                {

                    int i = r.ReserveFirstClassAnySeat();
                    if (i == 0)
                        cbFC1.Checked = true;
                    else if (i == 1)
                        cbFC2.Checked = true;
                    else if (i == 2)
                        cbFC3.Checked = true;
                    else if (i == 3)
                        cbFC4.Checked = true;
                    else if (i == 4)
                        cbFC5.Checked = true;

                    int seatNum = i + 1;
                    MessageBox.Show("You have reserved First Class Seat " + seatNum + totalSeats);
                    MessageLabel.Text = "You have reserved First Class Seat " + seatNum + totalSeats;
                    SeatsFirstFullDisplay();
                    
                }
            }

            // economy radio button
            else if (radioButtonEconomy.Checked) //Check if first class
            {
                if (r.IsEconomyClassAvailable())
                {
                    int i = r.ReserveEconomyClassAnySeat();
                    //MessageBox.Show("Economy " + i);
                    if (i == 0)
                        cbEC1.Checked = true;
                    else if (i == 1)
                        cbEC2.Checked = true;
                    else if (i == 2)
                        cbEC3.Checked = true;
                    else if (i == 3)
                        cbEC4.Checked = true;
                    else if (i == 4)
                        cbEC5.Checked = true;
                    int seatNum = i + 1;
                    MessageBox.Show("You have reserved Economy Class Seat " + seatNum + totalSeats);
                    MessageLabel.Text = "You have reserved Economy Class Seat " + seatNum + totalSeats;
                    SeatsEconomyFullDisplay();
                }
            }
            SeatsFullDisplay();
        }

        /// <summary>
        /// If all economy seats full, display message
        /// </summary>
        public void SeatsEconomyFullDisplay()
        {
            if (r.IsFirstClassAvailable() && !r.IsEconomyClassAvailable())
            {
                MessageBox.Show("Economy class is full. First Class is still available.");
                MessageLabel.Text = "Economy class is full. First Class is still available.";
            }
        }

        /// <summary>
        /// If all first class seats full, display message
        /// </summary>
        //This method can be called to show whether or not Economy or First class is available or not
        public void SeatsFirstFullDisplay()
        {
            if (!r.IsFirstClassAvailable() && r.IsEconomyClassAvailable())
            {
                MessageBox.Show("First Class is full. Economy class is still available.");
                MessageLabel.Text = "First Class is full. Economy class is still available.";
            }
        }

        /// <summary>
        /// If all seats full, display message
        /// </summary>
        public void SeatsFullDisplay()
        {
            if (!r.IsFirstClassAvailable() && !r.IsEconomyClassAvailable())
            {
                MessageBox.Show("This plane is full. Thanks for choosing the best airline ever!");
                MessageLabel.Text = "This plane is full. Thanks for choosing the best airline ever!";
            }
        }


        // This method is used for checking the checkboxes
        private void CheckChanged_click(object sender, EventArgs e)
        {

            //First Class side
            if (((CheckBox)sender) == cbFC1)
            {
                if (r.IsFirstClassSeatAvailable(0))
                {
                    r.ReserveFirstClassSeat(0);
                    cbFC1.Checked = true;
                    MessageBox.Show("You have reserved First Class Seat 1" + totalSeats);
                    MessageLabel.Text = "You have reserved First Class Seat 1" + totalSeats;
                }
                else
                {
                    r.UnReserveFirstClassSeat(0);
                    cbFC1.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 1" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 1" + totalSeats;
                }
            }

            //reserve checkbox 2
            if (((CheckBox)sender) == cbFC2)
            {
                if (r.IsFirstClassSeatAvailable(1))
                {
                    r.ReserveFirstClassSeat(1);
                    cbFC2.Checked = true;
                    MessageBox.Show("You have reserved First Class Seat 2" + totalSeats);
                    MessageLabel.Text = "You have reserved First Class Seat 2" + totalSeats;
                }
                else
                {
                    r.UnReserveFirstClassSeat(1);
                    cbFC2.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 2" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 2" + totalSeats;
                }
            }
            //reserve checkbox 3
            if (((CheckBox)sender) == cbFC3)
            {
                if (r.IsFirstClassSeatAvailable(2))
                {
                    r.ReserveFirstClassSeat(2);
                    cbFC3.Checked = true;
                    MessageBox.Show("You have reserved First Class Seat 3" + totalSeats);
                    MessageLabel.Text = "You have reserved First Class Seat 3" + totalSeats;
                }
                else
                {
                    r.UnReserveFirstClassSeat(2);
                    cbFC3.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 3" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 3" + totalSeats;
                }
            }
            //reserve checkbox 4
            if (((CheckBox)sender) == cbFC4)
            {
                if (r.IsFirstClassSeatAvailable(3))
                {
                    r.ReserveFirstClassSeat(3);
                    cbFC4.Checked = true;
                    MessageBox.Show("You have reserved First Class Seat 4" + totalSeats);
                    MessageLabel.Text = "You have reserved First Class Seat 4" + totalSeats;
                }
                else
                {
                    r.UnReserveFirstClassSeat(3);
                    cbFC4.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 4" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 4" + totalSeats;
                }
            }
            //reserve checkbox 5
            if (((CheckBox)sender) == cbFC5)
            {
                if (r.IsFirstClassSeatAvailable(4))
                {
                    r.ReserveFirstClassSeat(4);
                    cbFC5.Checked = true;
                    MessageBox.Show("You have reserved First Class Seat 5" + totalSeats);
                    MessageLabel.Text = "You have reserved First Class Seat 5" + totalSeats;
                }
                else
                {
                    r.UnReserveFirstClassSeat(4);
                    cbFC5.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 5" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 5" + totalSeats;
                }
            }


            //Economy side
            if (((CheckBox)sender) == cbEC1)
            {
                if (r.IsEconomyClassSeatAvailable(0))
                {
                    r.ReserveEconomyClassSeat(0);
                    cbEC1.Checked = true;
                    MessageBox.Show("You have reserved Economy Class Seat 1" + totalSeats);
                    MessageLabel.Text = "You have reserved Economy Class Seat 1" + totalSeats;
                }
                else
                {
                    r.UnReserveEconomyClassSeat(0);
                    cbEC1.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 1" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 1" + totalSeats;
                }
            }

            if (((CheckBox)sender) == cbEC2)
            {
                if (r.IsEconomyClassSeatAvailable(1))
                {
                    r.ReserveEconomyClassSeat(1);
                    cbEC2.Checked = true;
                    MessageBox.Show("You have reserved Economy Class Seat 2" + totalSeats);
                    MessageLabel.Text = "You have reserved Economy Class Seat 2" + totalSeats;
                }
                else
                {
                    r.UnReserveEconomyClassSeat(1);
                    cbEC2.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 2" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 2" + totalSeats;
                }
            }

            if (((CheckBox)sender) == cbEC3)
            {
                if (r.IsEconomyClassSeatAvailable(2))
                {
                    r.ReserveEconomyClassSeat(2);
                    cbEC3.Checked = true;
                    MessageBox.Show("You have reserved Economy Class Seat 3" + totalSeats);
                    MessageLabel.Text = "You have reserved Economy Class Seat 3" + totalSeats;
                }
                else
                {
                    r.UnReserveEconomyClassSeat(2);
                    cbEC3.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 3" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 1" + totalSeats;
                }
            }

            if (((CheckBox)sender) == cbEC4)
            {
                if (r.IsEconomyClassSeatAvailable(3))
                {
                    r.ReserveEconomyClassSeat(3);
                    cbEC4.Checked = true;
                    MessageBox.Show("You have reserved Economy Class Seat 4" + totalSeats);
                    MessageLabel.Text = "You have reserved Economy Class Seat 4" + totalSeats;
                }
                else
                {
                    r.UnReserveEconomyClassSeat(3);
                    cbEC4.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 4" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 4" + totalSeats;
                }
            }

            if (((CheckBox)sender) == cbEC5)
            {
                if (r.IsEconomyClassSeatAvailable(4))
                {
                    r.ReserveEconomyClassSeat(4);
                    cbEC5.Checked = true;
                    MessageBox.Show("You have reserved Economy Class Seat 5" + totalSeats);
                    MessageLabel.Text = "You have reserved Economy Class Seat 5" + totalSeats;
                }
                else
                {
                    r.UnReserveEconomyClassSeat(4);
                    cbEC5.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 5" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 5" + totalSeats;
                }
            }

        }

        


        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearReservation_Click(object sender, EventArgs e)
        {
            r.ClearCheckboxes();

            cbEC1.Checked = false;
            cbEC2.Checked = false;
            cbEC3.Checked = false;
            cbEC4.Checked = false;
            cbEC5.Checked = false;

            cbFC1.Checked = false;
            cbFC2.Checked = false;
            cbFC3.Checked = false;
            cbFC4.Checked = false;
            cbFC5.Checked = false;

            MessageLabel.Text = "Please reserve your airline seat.";
        }

        
    }
}

