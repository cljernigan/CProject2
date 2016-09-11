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
        private void SentenceBuilder_Load(object sender, EventArgs e)
        {
            foreach (Control control in base.Controls)
            {
                if (control is Label)
                {
                    control.Text = ControlString;
                }
           //     else if (control is Button)
             //   {
                   // if (control.Name = "R"%
              //      control.Text = "push";

              //  }
            }
        }

        private void AddWords(object sender, EventArgs e)
        {
            string _MyButton = ((Button)sender).Text;
            string CurrentString = SentenceOutLabel.Text;
            if (ControlString.Equals(CurrentString, StringComparison.Ordinal))
            {
                SentenceOutLabel.Text = "";
            }
            SentenceOutLabel.Text += _MyButton;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            SentenceOutLabel.Text = "";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            try
            {
                SentenceOutLabel.Text = SentenceOutLabel.Text.Remove(SentenceOutLabel.Text.Length - 1, 1);
            }
            catch
            {
                MessageBox.Show("You do not have anything to backspace!");
            }
        }

        private void SpaceButton_Click(object sender, EventArgs e)
        {
            string CurrentString = SentenceOutLabel.Text;
            if (ControlString.Equals(CurrentString, StringComparison.Ordinal))
            {
                SentenceOutLabel.Text = "";
            }
            SentenceOutLabel.Text += " ";
        }

        private void SelectListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
