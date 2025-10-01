namespace tudorial_9_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void conutrylebel_Click(object sender, EventArgs e)
        {

        }

        private void finlandpictureBox_Click(object sender, EventArgs e)
        {
            Conutrylebel.Text = "芬蘭";
        }

        private void francepictureBox_Click(object sender, EventArgs e)
        {
            Conutrylebel.Text = "法國";
        }

        private void germanypictureBox_Click(object sender, EventArgs e)
        {
            Conutrylebel.Text = "德國";

        }
    }
}
