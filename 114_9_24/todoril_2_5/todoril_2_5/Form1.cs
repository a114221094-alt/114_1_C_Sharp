namespace todoril_2_5
{
    // Form1 �O�D����������O�A�~�Ӧ� Form
    public partial class Form1 : Form
    {
        // �غc�禡�A��l�Ƥ���
        public Form1()
        {
            InitializeComponent(); // ��l�ƪ�椸��
        }

        // �� pictureBox2 �Q�I����Ĳ�o���ƥ�B�z�禡
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // �ثe�|����@����\��
        }

        // ������J��Ĳ�o���ƥ�B�z�禡
        private void Form1_Load(object sender, EventArgs e)
        {
            // ���åd���I���P�������Ϥ�
            cardbackpictureBox.Visible = false;
            cardfacepictureBox.Visible = false;
        }

        // ��u��ܭI���v���s�Q�I����Ĳ�o���ƥ�B�z�禡
        private void showbackbutton_Click(object sender, EventArgs e)
        {
            // ��ܥd���I���A���åd������
            cardbackpictureBox.Visible = true;
            cardfacepictureBox.Visible = false;
        }

        // ��u��ܥ����v���s�Q�I����Ĳ�o���ƥ�B�z�禡
        private void showfacebutton_Click(object sender, EventArgs e)
        {
            // ��ܥd�������A���åd���I��
            cardbackpictureBox.Visible = false;
            cardfacepictureBox.Visible = true;  
        }
    }
}
