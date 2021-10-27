using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineGUI
{
    public class Validator
    {
        private static string title = "Entry Error";

        public static string Title { get; set; }

        /// <summary>
        /// Checks if textBox is not empty
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsPresent(TextBox textBox)
        {
            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Focus();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Cheks is passenger age >= 0 and < 200
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsInt0to199(TextBox textBox)
        {
            int number = 0;
            if (Int32.TryParse(textBox.Text, out number) &&
                Convert.ToInt32(textBox.Text) >= 0 && 
                Convert.ToInt32(textBox.Text) < 200)
            {
                 return true;                               
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be an integer from 0 to 199.", Title);
                textBox.Focus();

                return false;
            }
        }

        /// <summary>
        /// Check format of mail (very simple)
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsValidEmail(TextBox textBox)
        {
            if (textBox.Text.IndexOf("@") == -1 ||
                 textBox.Text.IndexOf(".") == -1)
            {
                MessageBox.Show(textBox.Tag + " must be a valid email address.", Title);
                textBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

