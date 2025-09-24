namespace todoril_2_5
{
    // Form1 是主視窗表單類別，繼承自 Form
    public partial class Form1 : Form
    {
        // 建構函式，初始化元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單元件
        }

        // 當 pictureBox2 被點擊時觸發的事件處理函式
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // 目前尚未實作任何功能
        }

        // 當表單載入時觸發的事件處理函式
        private void Form1_Load(object sender, EventArgs e)
        {
            // 隱藏卡片背面與正面的圖片
            cardbackpictureBox.Visible = false;
            cardfacepictureBox.Visible = false;
        }

        // 當「顯示背面」按鈕被點擊時觸發的事件處理函式
        private void showbackbutton_Click(object sender, EventArgs e)
        {
            // 顯示卡片背面，隱藏卡片正面
            cardbackpictureBox.Visible = true;
            cardfacepictureBox.Visible = false;
        }

        // 當「顯示正面」按鈕被點擊時觸發的事件處理函式
        private void showfacebutton_Click(object sender, EventArgs e)
        {
            // 顯示卡片正面，隱藏卡片背面
            cardbackpictureBox.Visible = false;
            cardfacepictureBox.Visible = true;  
        }
    }
}
