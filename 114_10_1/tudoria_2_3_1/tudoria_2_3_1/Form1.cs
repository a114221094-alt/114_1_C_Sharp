using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tudoria_2_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showdatebutton_Click(object sender, EventArgs e)
        {
            string dayofweek=dayofweekTextbox.Text;
            string month=monthTextbox.Text;
            string year=yearTextbox.Text;
            string dayofmonth=dayofmonthTextbox.Text;

            string output="中華明國"+year+" 年"+month+" 月"+dayofmonth+" 日"+"，星期"+dayofweek;

            dateoutputlabel.Text=output;

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
        dayofweekTextbox.Text="";
            monthTextbox.Text="";
            yearTextbox.Text="";
            dayofmonthTextbox.Text="";
            dateoutputlabel.Text="";
        }
    }
}
