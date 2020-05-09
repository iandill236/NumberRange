using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NumberRange
{
    public partial class Form1 : Form
    {
        int endNumber;
        int startNumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void valueButton_Click(object sender, EventArgs e)
        {
           

            startNumber = Convert.ToInt16(startBox.Text);
            endNumber = Convert.ToInt16(endBox.Text);

            for (int number = startNumber; number <= endNumber; number++)
            {
                numberLabel.Text += "" + number;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            numberLabel.Text = "";
            endNumber = 0;
            startNumber = 0;
        }
    }
}
