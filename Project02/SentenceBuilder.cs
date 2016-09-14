//Christopher Jernigan 9/13/2016
// Project 2 ITE 136 C# Programing 1
//Starting out with visual c# 4e Giddis p 196


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project02
{
    public partial class SentenceBuilder : Form
    {
        public SentenceBuilder()
        {
            InitializeComponent();

        }

        string ControlString = "YOUR TEXT WILL GO HERE";
        // String to compare other methods against to determine if label is blank
        private void SentenceBuilder_Load(object sender, EventArgs e)
        {
            SentenceOutLabel.Text = ControlString;

            int tableindex = 0;
            int Row = 6;
            int Columns = 8;
            for (int r = 1; r <= Row; r++)
            {
                for (int c = 1; c <= Columns; c++)
                {
                    var cntrl = this.Controls.Find(string.Format("R{0}C{1}Button", r, c), false);
                    if (cntrl.Length == 1)
                    {
                        if ((Control)cntrl[0] is Button) cntrl[0].TabIndex = tableindex;
                        tableindex++;

                    }
                }
            }
            SpaceButton.TabIndex = tableindex++;
            BackspaceButton.TabIndex = tableindex++;
            ClearButton.TabIndex = tableindex++;
            ExitButton.TabIndex = tableindex++;
            


        }




        private void AddWords(object sender, EventArgs e)
        {
            // send text value of button to SentenceOutLabel
            string _MyButton = ((Button)sender).Text; // assign value to temporary string so value can be added to SentenceOutLabel
            string CurrentString = SentenceOutLabel.Text;
            //Takes current text value for SentenceOutLabel and compares to control label to see if initial value is present if so clear
            if (ControlString.Equals(CurrentString, StringComparison.Ordinal))
            {
                SentenceOutLabel.Text = "";
            }
            SentenceOutLabel.Text += _MyButton; // add temporary string value to current value of SentenceOutLabel
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close form 
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
                SentenceOutLabel.Text = ""; // Clears value of SentenceOutLabel
     
   
         }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                SentenceOutLabel.Text = SentenceOutLabel.Text.Remove(SentenceOutLabel.Text.Length - 1, 1); // removes one character from SentenceOutLabel
            }
            catch
            {
                MessageBox.Show("You do not have anything to backspace!"); // Tells user there is nothing to remove
            }
        }

        private void SpaceButton_Click(object sender, EventArgs e)
        {
            string CurrentString = SentenceOutLabel.Text;
            //Takes current text value for SentenceOutLabel and compares to control label to see if initial value is present if so clear
            if (ControlString.Equals(CurrentString, StringComparison.Ordinal))
            {
                SentenceOutLabel.Text = "";
            }
            SentenceOutLabel.Text += " ";
        }

    }
}
