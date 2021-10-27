using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineGUI
{
    public partial class Form1 : Form
    {
        IReservable Airline;

        public Form1()
        {
            InitializeComponent();
            Airline = new Reserver();
        }

                      
        private void rsvbtn_Click(object sender, EventArgs e)
        {
            if (rdofirst.Checked && Airline.IsFirstClassAvailable())
            {
                Airline.ReserveFirstClassAnySeat();
            }
            else if (rdoecon.Checked && Airline.IsEconomyClassAvailable())
            {
                Airline.ReserveEconomyClassAnySeat();
            }
            updatecheckboxes();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatecheckboxes();
        }

        private void updatecheckboxes()
        {
            bool[] seats = new bool[5];
            seats = Airline.GetFirstClassSeats();
            if (seats[0])
                cb1.Checked = true;
            else
                cb1.Checked = false;
            if (seats[1])
                cb2.Checked = true;
            else
                cb2.Checked = false;
            if (seats[2])
                cb3.Checked = true;
            else
                cb3.Checked = false;
            if (seats[3])
                cb4.Checked = true;
            else
                cb4.Checked = false;
            if (seats[4])
                cb5.Checked = true;
            else
                cb5.Checked = false;

            seats = Airline.GetEconomyClassSeats();
            if (seats[0])
                cb6.Checked = true;
            else
                cb6.Checked = false;
            if (seats[1])
                cb7.Checked = true;
            else
                cb7.Checked = false;
            if (seats[2])
                cb8.Checked = true;
            else
                cb8.Checked = false;
            if (seats[3])
                cb9.Checked = true;
            else
                cb9.Checked = false;
            if (seats[4])
                cb10.Checked = true;
            else
                cb10.Checked = false;
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
           rdofirst.Checked = true;
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
           rdofirst.Checked = true;
        }

        private void cb3_CheckedChanged(object sender, EventArgs e)
        {
           rdofirst.Checked = true;
        }

        private void cb4_CheckedChanged(object sender, EventArgs e)
        {
           rdofirst.Checked = true;
        }

        private void cb5_CheckedChanged(object sender, EventArgs e)
        {
           rdofirst.Checked = true;
        }

        private void cb6_CheckedChanged(object sender, EventArgs e)
        {
           rdoecon.Checked = true;
        }

        private void cb7_CheckedChanged(object sender, EventArgs e)
        {
           rdoecon.Checked = true;
        }

        private void cb8_CheckedChanged(object sender, EventArgs e)
        {
           rdoecon.Checked = true;
        }

        private void cb9_CheckedChanged(object sender, EventArgs e)
        {
           rdoecon.Checked = true;
        }

        private void cb10_CheckedChanged(object sender, EventArgs e)
        {
           rdoecon.Checked = true;
        }

    }
}
