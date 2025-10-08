using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Sale_Price_Calculator
{
    // 主表單類別：用於顯示 UI 控制項並處理使用者互動
    // 此類別與 Designer 檔案配合，Designer 定義控制項與外觀，
    // 本檔負責事件處理器與商業邏輯（目前為範例結構）。
    public partial class Form1 : Form
    {
        // 建構子：初始化元件
        // InitializeComponent() 會建立並配置 Designer 定義的所有控制項。
        public Form1()
        {
            InitializeComponent();
        }

        // 計算按鈕的點擊事件處理器
        // 1. 解析原價與折扣百分比（接受當地數字格式）
        // 2. 驗證範圍（原價 >= 0，折扣 0~100）
        // 3. 計算並更新 salePriceLabel.Text（以繁體中文貨幣格式顯示）
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 使用台灣文化格式解析與顯示（可改為 CultureInfo.CurrentCulture）
            var culture = CultureInfo.CreateSpecificCulture("zh-TW");

            // 解析原價
            if (!decimal.TryParse(originalPriceTextBox.Text, NumberStyles.Number, culture, out decimal originalPrice))
            {
                MessageBox.Show("請輸入有效的原價（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                originalPriceTextBox.Focus();
                return;
            }

            // 解析折扣百分比
            if (!decimal.TryParse(discountPercentageTextBox.Text, NumberStyles.Number, culture, out decimal discountPercent))
            {
                MessageBox.Show("請輸入有效的折扣百分比（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                discountPercentageTextBox.Focus();
                return;
            }

            // 驗證數值範圍
            if (originalPrice < 0m)
            {
                MessageBox.Show("原價不能為負數。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                originalPriceTextBox.Focus();
                return;
            }

            if (discountPercent < 0m || discountPercent > 100m)
            {
                MessageBox.Show("折扣百分比需介於 0 到 100。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                discountPercentageTextBox.Focus();
                return;
            }

            // 計算特價
            decimal salePrice = originalPrice * (1m - discountPercent / 100m);

            // 更新介面：以貨幣格式顯示（例如 NT$1,234.56）
            salePriceLabel.Text = salePrice.ToString("C2", culture);
        }

        // 離開按鈕的點擊事件處理器：關閉表單
        // 若表單為應用程式主視窗，Close() 會結束應用程式。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }

        // 折扣百分比輸入框內容變更事件處理器
        // 可用於即時驗證使用者輸入（例如只允許數字與小數點，或顯示即時錯誤提示）。
        // 目前保留為空實作，視需求補上輸入驗證或即時更新功能。
        private void discountPercentageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // 原價提示標籤被點擊事件處理器
        // 通常標籤不需要點擊事件，若由設計工具產生空的事件處理器可留空或移除。
        private void originalPricePromptLabel_Click(object sender, EventArgs e)
        {

        }

        // 原價輸入框內容變更事件處理器
        // 可用於即時驗證使用者輸入或自動格式化（例如千分位或貨幣符號），
        // 若不需要可保持空實作或移除綁定。
        private void originalPriceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
