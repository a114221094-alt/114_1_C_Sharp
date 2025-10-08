using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // Track total amount in dollars
        private decimal totalAmount = 0m;

        public Form1()
        {
            InitializeComponent();
        }

        // Add click event handlers referenced by the Designer
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalAmount += 0.05m;
            UpdateTotalLabel();
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalAmount += 0.10m;
            UpdateTotalLabel();
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalAmount += 0.25m;
            UpdateTotalLabel();
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            totalAmount += 0.50m;
            UpdateTotalLabel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTotalLabel()
        {
            // Show as currency
            totalLabel.Text = totalAmount.ToString("C");
        }
    }
}
