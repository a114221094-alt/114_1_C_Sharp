using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        // 新增計數欄位與隨機產生器
        private int headsCount = 0;
        private int tailsCount = 0;
        private readonly Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            // 使用類別層級的 Random 以避免重複種子
            int sideUp = rand.Next(2); // 0 或 1

            if (sideUp == 0)
            {
                // 顯示正面圖、隱藏反面圖，並更新計數與標籤
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
                headsCount++;
                headsCountLabel.Text = "正面: " + headsCount;
            }
            else
            {
                // 顯示反面圖、隱藏正面圖，並更新計數與標籤
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;
                tailsCount++;
                tailsCountLabel.Text = "反面: " + tailsCount;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        private void headsPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
