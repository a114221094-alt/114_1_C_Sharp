namespace checkboxdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = " ";

            if (checkBox1.Checked)
            {
                message=message+"夏威夷";
            }
            if (checkBox2.Checked)
            {
                message=message+"章魚燒";
            }
            if (checkBox3.Checked)
            {
                message=message+"綜合海鮮";

            }
            if (checkBox4.Checked)
            {
                message=message+"意式火腿";
            }
            if(message==" ")
            {
             message="您沒有選擇任何口味";
            }
            MessageBox.Show(message,"您選擇的披薩口味是: ");
            {
                
            }
        }
    }
}
