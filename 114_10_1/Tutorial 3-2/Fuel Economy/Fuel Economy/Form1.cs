using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        // 建構函式，初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者按下「計算MPG」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
           double kilometers;
            double liters;
            double kmpl;
            // 讀取使用者輸入的英里數和加侖數，
            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);
            // 計算每公升公里數
            kmpl = kilometers / liters;
            // 顯示結果，格式化為小數點後兩位
            mpgLabel.Text = kmpl.ToString("n2");

        }

        // 當使用者按下「離開」按鈕時執行，關閉表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        // 當使用者點擊英里提示標籤時執行（目前未使用）
        private void milesPromptLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
