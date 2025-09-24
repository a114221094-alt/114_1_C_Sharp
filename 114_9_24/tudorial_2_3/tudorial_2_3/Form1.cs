using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tudorial_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void idalianbutton_Click(object sender, EventArgs e)
        {
            translationlabel.Text = "buongiorno";
        }

        private void spanishbutton_Click(object sender, EventArgs e)
        {
            translationlabel.Text = "buenos dias";
        }

        private void germanbutton_Click(object sender, EventArgs e)
        {
            translationlabel.Text = "guten tag";
        }
    }
}
