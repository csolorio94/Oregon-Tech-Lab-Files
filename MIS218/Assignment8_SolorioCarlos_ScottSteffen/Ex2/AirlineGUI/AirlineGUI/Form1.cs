using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AirlineGUI
{
    public partial class Form1 : Form
    {

        bool isAuto = false; //there are two selections: manual automatic (whatever is available)
        bool isLoad = false; //because of reuse of some methods, some unnecessary  messages should be ignored

        public Form1()
        {
            InitializeComponent();
            InitSeats();
        }

        

        CheckBox[] Initseats = new CheckBox[10];
        IReservable r = new Reserver();
        string totalSeats = " of 5";
        

        private void InitSeats()
        {
            Initseats[0] = cbFC1;
            Initseats[1] = cbFC2;
            Initseats[2] = cbFC3;
            Initseats[3] = cbFC4;
            Initseats[4] = cbFC5;

            Initseats[5] = cbEC1;
            Initseats[6] = cbEC2;
            Initseats[7] = cbEC3;
            Initseats[8] = cbEC4;
            Initseats[9] = cbEC5;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBoxFirst.Controls)
                if (control is CheckBox)
                    control.Click += CheckChanged_click
                        ;

            foreach (Control control in this.groupBoxEconomy.Controls)
                if (control is CheckBox)
                    control.Click += CheckChanged_click;
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
                radioButtonEconomy.Enabled = false;
                radioButtonFirst.Focus();
            }
            else radioButtonEconomy.Enabled = true;
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
                radioButtonFirst.Enabled = false;
                radioButtonEconomy.Focus();
            }
            else radioButtonFirst.Enabled = true;
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


        //This method is used for checking the checkboxes
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
                    SeatsFirstFullDisplay();
                }
                else
                {
                    r.UnReserveFirstClassSeat(0);
                    cbFC1.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 1" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 1" + totalSeats;
                    SeatsFirstFullDisplay();
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
                    SeatsFirstFullDisplay();
                }
                else
                {
                    r.UnReserveFirstClassSeat(1);
                    cbFC2.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 2" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 2" + totalSeats;
                    SeatsFirstFullDisplay();
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
                    SeatsFirstFullDisplay();
                }
                else
                {
                    r.UnReserveFirstClassSeat(2);
                    cbFC3.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 3" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 3" + totalSeats;
                    SeatsFirstFullDisplay();
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
                    SeatsFirstFullDisplay();
                }
                else
                {
                    r.UnReserveFirstClassSeat(3);
                    cbFC4.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 4" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 4" + totalSeats;
                    SeatsFirstFullDisplay();
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
                    SeatsFirstFullDisplay();
                }
                else
                {
                    r.UnReserveFirstClassSeat(4);
                    cbFC5.Checked = false;
                    MessageBox.Show("You have unreserved First Class Seat 5" + totalSeats);
                    MessageLabel.Text = "You have unreserved First Class Seat 5" + totalSeats;
                    SeatsFirstFullDisplay();
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
                    SeatsEconomyFullDisplay();
                }
                else
                {
                    r.UnReserveEconomyClassSeat(0);
                    cbEC1.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 1" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 1" + totalSeats;
                    SeatsEconomyFullDisplay();
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
                    SeatsEconomyFullDisplay();
                }
                else
                {
                    r.UnReserveEconomyClassSeat(1);
                    cbEC2.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 2" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 2" + totalSeats;
                    SeatsEconomyFullDisplay();
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
                    SeatsEconomyFullDisplay();
                }
                else
                {
                    r.UnReserveEconomyClassSeat(2);
                    cbEC3.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 3" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 1" + totalSeats;
                    SeatsEconomyFullDisplay();
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
                    SeatsEconomyFullDisplay();
                }
                else
                {
                    r.UnReserveEconomyClassSeat(3);
                    cbEC4.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 4" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 4" + totalSeats;
                    SeatsEconomyFullDisplay();
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
                    SeatsEconomyFullDisplay();
                }
                else
                {
                    r.UnReserveEconomyClassSeat(4);
                    cbEC5.Checked = false;
                    MessageBox.Show("You have unreserved Economy Class Seat 5" + totalSeats);
                    MessageLabel.Text = "You have unreserved Economy Class Seat 5" + totalSeats;
                    SeatsEconomyFullDisplay();
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

            DisplayAllSeats();

            SeatsEconomyFullDisplay();
            SeatsFirstFullDisplay();
            MessageLabel.Text = "Please reserve your airline seat.";
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool[] seats = new bool[10];

            // Get first and economy reservations
            bool[] firstClass = r.GetFirstClassSeats();
            bool[] economyClass = r.GetEconomyClassSeats();

            // Combine both arrays into one
            Array.Copy(firstClass, 0, seats, 0, firstClass.Length);
            Array.Copy(economyClass, 0, seats, 5, economyClass.Length);

            // Save seats array with Reserver class
            r.Save(seats);
            MessageBox.Show("Seats are saved.");
        }

        private void ResetAll()
        {
            r.ResetFirstClass();
            r.ResetEconomyClass();
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ResetAll();

            
            bool[] allSeats = r.Fill();
            for (int i = 0; i < allSeats.Length; i++)
            {
                bool isReserved = allSeats[i];
                if (isReserved == true)
                {
                    if (i < 5)
                    {
                        r.ReserveFirstClassSeat(i);
                    }
                    else
                    {
                        r.ReserveEconomyClassSeat(i - 5);
                    }
                }
            }

            DisplayAllSeats();
            
        }

        private void DisplayAllSeats() //Updates the checkboxes to reflect the array.
        {
            cbFC1.Checked = r.GetFirstClassSeats()[0];
            cbFC2.Checked = r.GetFirstClassSeats()[1];
            cbFC3.Checked = r.GetFirstClassSeats()[2];
            cbFC4.Checked = r.GetFirstClassSeats()[3];
            cbFC5.Checked = r.GetFirstClassSeats()[4];

            cbEC1.Checked = r.GetEconomyClassSeats()[0];
            cbEC2.Checked = r.GetEconomyClassSeats()[1];
            cbEC3.Checked = r.GetEconomyClassSeats()[2];
            cbEC4.Checked = r.GetEconomyClassSeats()[3];
            cbEC5.Checked = r.GetEconomyClassSeats()[4];
            
        }
    }
    
}

