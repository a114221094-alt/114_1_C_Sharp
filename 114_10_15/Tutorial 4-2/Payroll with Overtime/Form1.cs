using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    /// <summary>
    /// 主表單類別：處理使用者輸入的工作時數與時薪，並可計算總薪資（含加班處理）。
    /// 此檔案主要包含事件處理器的實作（例如按鈕的 Click 事件）。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件。
        /// InitializeComponent() 會由 Designer 自動產生並設定所有控制項（位置、大小、文字等）。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        // 修正 CS1513: 移除多餘的大括號，將 calculateButton_Click 方法的結尾正確放置在 exitButton_Click 之前。
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // TODO: 在此加入輸入驗證與計算邏輯。
            const decimal baseHours = 40m;
            const decimal overtimeMultiplier = 1.5m;
            decimal hoursWorked;
            decimal hourlyPayRate;
            decimal grossPay;
            try
            {
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);
                if (hoursWorked <= baseHours)
                {
                    grossPay = hoursWorked * hourlyPayRate;
                }
                else
                {
                    decimal overtimeHours = hoursWorked - baseHours;
                    grossPay = (baseHours * hourlyPayRate) + (overtimeHours * hourlyPayRate * overtimeMultiplier);
                }
                grossPayLabel.Text = grossPay.ToString("C2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            // 範例步驟（註解）：
            // 1. 讀取字串：string hoursText = hoursWorkedTextBox.Text;
            // 2. 嘗試轉換：if (!double.TryParse(hoursText, out double hours)) { /* 顯示錯誤 */ return; }
            // 3. 同理解析時薪：if (!double.TryParse(hourlyPayRateTextBox.Text, out double rate)) { /* 顯示錯誤 */ return; }
            // 4. 計算：double grossPay = CalculateGrossPay(hours, rate);
            // 5. 顯示：grossPayLabel.Text = grossPay.ToString("C2");

            // 如果您要我現在就實作計算邏輯，請回覆「請實作計算邏輯」，我會把上述流程寫入程式。


            /// <summary>
            /// 清除按鈕的點擊事件處理器：
            /// 1. 清空輸入欄位與輸出標籤的內容。
            /// 2. 將焦點重設到第一個輸入欄位（hoursWorkedTextBox）。
            ///</summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox 以及顯示總薪資的 Label。
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // 把輸入焦點設回工作時數欄位，方便使用者繼續輸入。
            hoursWorkedTextBox.Focus();
        }

        /// <summary>
        /// 離開按鈕的點擊事件處理器：關閉目前表單。
        /// 若應用程式在此表單關閉後仍有其他表單或背景處理，請確認是否需要呼叫 Application.Exit()。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（會觸發表單的 Closing/Closed 事件）。
            this.Close();
        }

        // 以下可加入額外的輔助方法，例如計算總薪資的函式：
        // private double CalculateGrossPay(double hours, double rate) { ... }
        // 若需要，我可以新增實作並替換 calculateButton_Click 中的 TODO。
    }
}
