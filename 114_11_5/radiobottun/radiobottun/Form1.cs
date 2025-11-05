namespace radiobottun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            string message = "點餐內容 ";
            string drink = "";
            string sandwich = "";


            if (cfbutton.Checked)
            {
                drink = "咖啡 ";
            }
            else if (radteaButton3.Checked)
            {
                drink = "紅茶 ";
            }
            else if (jcyButton2.Checked)
            {
                drink = "果汁 ";
            }
            else
                drink = " ";

            if (jambutton.Checked)
            {
                sandwich = "果醬三明治 ";
            }
            else if (tunaradioButton5.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else if (hambutton.Checked)
            {
                sandwich = "火腿三明治 ";
            }
            else
                sandwich = " ";
            message += drink + sandwich;
            MessageBox.Show(message);

        }

        private void leavebutton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
