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

        //bool isAuto = false; //there are two selections: manual automatic (whatever is available)
        //bool isLoad = false; //because of reuse of some methods, some unnecessary  messages should be ignored

        public Form1()
        {
            InitializeComponent();
            InitSeats();
        }

        

        CheckBox[] Initseats = new CheckBox[10];
        IReservable r = new Reserver();
        Validator Validator = new Validator();
        string totalSeats = " of 5";

        ToolTip customerInfo = new ToolTip();

                
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
                    control.Click += CheckChanged_click;                    

            foreach (Control control in this.groupBoxEconomy.Controls)
                if (control is CheckBox)
                    control.Click += CheckChanged_click;

            foreach (Control control in groupBoxFirst.Controls)
                if (control is CheckBox)
                    control.MouseHover += Control_MouseHover;

            foreach (Control control in groupBoxEconomy.Controls)
                if (control is CheckBox)
                    control.MouseHover += Control_MouseHover;
        }

        

        private void buttonReserve_Click(object sender, EventArgs e)
        {

            if (IsValid() == true)
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
                        MessageBox.Show("You have reserved First Class Seat " + seatNum + totalSeats, "Reserve");
                        MessageLabel.Text = "You have reserved First Class Seat " + seatNum + totalSeats;
                        UpdateFirstPassenger(seatNum - 1);
                        SeatsFirstFullDisplay();
                        ClearPassengerFields();
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
                        MessageBox.Show("You have reserved Economy Class Seat " + seatNum + totalSeats, "Reserve");
                        MessageLabel.Text = "You have reserved Economy Class Seat " + seatNum + totalSeats;
                        UpdateEconomyPassenger(seatNum - 1);
                        ClearPassengerFields();
                        SeatsEconomyFullDisplay();
                    }
                }
                SeatsFullDisplay();

            }
        }

        /// <summary>
        /// If all economy seats full, display message
        /// </summary>
        public void SeatsEconomyFullDisplay()
        {
            if (r.IsFirstClassAvailable() && !r.IsEconomyClassAvailable())
            {
                MessageBox.Show("Economy class is full. First Class is still available.", "Economy Class Full");
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
                MessageBox.Show("First Class is full. Economy class is still available.", "First Class Full");
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
                MessageBox.Show("This plane is full. Thanks for choosing the best airline ever!", "Airplane Full");
                MessageLabel.Text = "This plane is full. Thanks for choosing the best airline ever!";
                radioButtonEconomy.Enabled = false;
                radioButtonFirst.Enabled = false;
                buttonClearReservation.Focus();
            }
            

        }
        
        //This method is used for checking the checkboxes
        private void CheckChanged_click(object sender, EventArgs e)
        {           

                foreach (var checkBox in groupBoxFirst.Controls.OfType<CheckBox>())
                {
                    int index = int.Parse(checkBox.Name.Substring(4));
                    if (((CheckBox)sender) == checkBox)
                    {
                        if (r.IsFirstClassSeatAvailable(index - 1))
                        {
                            if (IsValid() == true)
                            {
                                r.ReserveFirstClassSeat(index - 1);
                                MessageBox.Show("You have reserved First Class Seat " + Convert.ToString(index) + totalSeats, "Unreserve");
                                MessageLabel.Text = "You have reserved First Class Seat " + Convert.ToString(index) + totalSeats;
                                UpdateFirstPassenger(index - 1);
                                ClearPassengerFields();
                            }
                        }
                        else
                        {
                            r.UnReserveFirstClassSeat(index - 1);
                            MessageBox.Show("You have unreserved First Class Seat " + Convert.ToString(index) + totalSeats, "Unreserve");
                            MessageLabel.Text = "You have unreserved First Class Seat " + Convert.ToString(index) + totalSeats;
                            UpdateFirstPassenger(index - 1);
                        }

                        
                    }
                }
                foreach (var checkBox in groupBoxEconomy.Controls.OfType<CheckBox>())
                {
                    int index = int.Parse(checkBox.Name.Substring(4));
                    if (((CheckBox)sender) == checkBox)
                    {
                        if (r.IsEconomyClassSeatAvailable(index - 1))
                        {
                            if (IsValid() == true)
                            {
                            r.ReserveEconomyClassSeat(index - 1);
                            MessageBox.Show("You have reserved Economy Class Seat " + Convert.ToString(index) + totalSeats, "Reserve");
                            MessageLabel.Text = "You have reserved Economy Class Seat " + Convert.ToString(index) + totalSeats;
                            UpdateEconomyPassenger(index - 1);
                            ClearPassengerFields();
                            }
                        }
                        else
                        {
                            r.UnReserveEconomyClassSeat(index - 1);
                            MessageBox.Show("You have unreserved Economy Class Seat " + Convert.ToString(index) + totalSeats, "Reserve");
                            MessageLabel.Text = "You have unreserved Economy Class Seat " + Convert.ToString(index) + totalSeats;
                            UpdateEconomyPassenger(index - 1);
                        }

                        
                    }
                }

                DisplayAllSeats();
                SeatsEconomyFullDisplay();
                SeatsFirstFullDisplay();
                SeatsFullDisplay();
                
                        
        }

        private void Control_MouseHover(object sender, EventArgs e)
        {            
            
            foreach (var checkBox in groupBoxFirst.Controls.OfType<CheckBox>())
            {
                int index = int.Parse(checkBox.Name.Substring(4));
                if (((CheckBox)sender) == checkBox)
                {
                    if (checkBox.Checked == true)
                    {                                             
                        customerInfo.SetToolTip(checkBox, r.GetFNames()[index - 1] +
                            "\n" + Convert.ToString(r.GetFAge()[index - 1]) + "\n" + r.GetFEmails()[index - 1]);
                    }
                    else
                    {                        
                        customerInfo.SetToolTip(checkBox, "Seat is available");
                    }
                }
            }
            foreach (var checkBox in groupBoxEconomy.Controls.OfType<CheckBox>())
            {
                int index = int.Parse(checkBox.Name.Substring(4));
                if (((CheckBox)sender) == checkBox)
                {
                    if (checkBox.Checked == true)
                    {                        
                        customerInfo.SetToolTip(checkBox, r.GetENames()[index - 1] +
                            "\n" + Convert.ToString(r.GetEAge()[index - 1]) + "\n" + r.GetEEmails()[index - 1]);
                    }
                    else
                    {                        
                        customerInfo.SetToolTip(checkBox, "Seat is available.");
                    }
                }
            }
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Do you wish to save your seats before exiting?",
                                                  "Exit",
                                                  MessageBoxButtons.YesNoCancel,
                                                  MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button3);

            if (button == DialogResult.Yes)
            {
                r.Save();
                r.SavePassengers();
                MessageBox.Show("Seats saved.", "Saved");
                this.Close();
            }
            else if (button == DialogResult.No)
            {
                this.Close();
            }
                       
        }

        private void buttonClearReservation_Click(object sender, EventArgs e)
        {
            ResetAll();

            r.ClearCheckboxes();

            DisplayAllSeats();

            SeatsEconomyFullDisplay();
            SeatsFirstFullDisplay();
            SeatsFullDisplay();
            ClearPassengerFields();
            MessageLabel.Text = "Please reserve your airline seat.";
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("Are you sure you would like to save these seats?",
                                                  "Seats",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question,
                                                  MessageBoxDefaultButton.Button2);
            
            if (button == DialogResult.Yes)
            {
                r.Save();
                r.SavePassengers();
                
            }           
            
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
            ClearPassengerFields();
            r.LoadPassenger();
            MessageBox.Show("Seats have been loaded.");
            DisplayAllSeats();        

        }

        
        private void DisplayAllSeats()  //Updates the checkboxes to reflect the array.
        {
            foreach (var checkBox in groupBoxFirst.Controls.OfType<CheckBox>())
            {
                int index = int.Parse(checkBox.Name.Substring(4));
                checkBox.Checked = r.GetFirstClassSeats()[index - 1];
            }
            foreach (var checkBox in groupBoxEconomy.Controls.OfType<CheckBox>())
            {
                int index = int.Parse(checkBox.Name.Substring(4));
                checkBox.Checked = r.GetEconomyClassSeats()[index - 1];
            }
        }

        private bool IsValid()
        {
            return
                Validator.IsPresent(txtBoxLastName) &&
                Validator.IsPresent(txtBoxFirstName) &&
                Validator.IsPresent(txtBoxAge) &&
                Validator.IsInt0to199(txtBoxAge) &&
                Validator.IsPresent(txtBoxEmail) &&
                Validator.IsValidEmail(txtBoxEmail);
        }

        private void UpdateFirstPassenger(int checkedSeat)
        {
            r.FirstPassengerName(checkedSeat, txtBoxLastName.Text + ", " + txtBoxFirstName.Text);            
            r.FirstEmail(checkedSeat, txtBoxEmail.Text);

            if (txtBoxAge.Text == "")//Handles the empty text being attempting to be converted.
            {
                r.FirstAge(checkedSeat, 0);
            }
            else r.FirstAge(checkedSeat, Convert.ToInt32(txtBoxAge.Text));
        }
        
        private void UpdateEconomyPassenger(int checkedSeat)
        {
            r.EconomyPassengerName(checkedSeat, txtBoxLastName.Text + ", " + txtBoxFirstName.Text);            
            r.EconomyEmail(checkedSeat, txtBoxEmail.Text);

            if (txtBoxAge.Text == "")//Handles the empty text being attempting to be converted.
            {
                r.EconomyAge(checkedSeat, 0);
            }
            else r.EconomyAge(checkedSeat, Convert.ToInt32(txtBoxAge.Text));
        }

        private void ClearPassengerFields() 
        {
            //Comment out for faster testing.
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxAge.Text = "";
            txtBoxEmail.Text = "";
        }
    }
    
}

