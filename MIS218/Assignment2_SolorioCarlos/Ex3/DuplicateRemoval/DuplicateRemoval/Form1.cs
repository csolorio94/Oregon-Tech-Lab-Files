using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateRemoval

    //code help from Daniel Salgado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class Word
        {
            public string Char { get; set; }
            public int Duplicate { get; set; }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {

            string sentence = sentenceBox.Text;
            var wordList = sentence.Split(null);
            var output = wordList.GroupBy(x => x).Select(y => new Word { Char = y.Key, Duplicate = y.Count() }).OrderBy(z => z.Duplicate);
            foreach (var item in output)
            {
                if (item.Duplicate == 1)
                    duplicatesBox.Text += item.Char + " : " + item.Duplicate + Environment.NewLine;
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            duplicatesBox.Text = "";
            
        }
    }

        
}

   

