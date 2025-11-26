using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;  // 宣告輸入檔案物件
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額
            string line; // 儲存讀取的行                        

            
           if(openFile.ShowDialog() == DialogResult.OK)
            {
                inputFile = File.OpenText(openFile.FileName);  // 開啟檔案
                salesListBox.Items.Clear(); // 清除清單框內容

                while (!inputFile.EndOfStream)  // 讀取直到檔案結尾
                {
                    line = inputFile.ReadLine();
                    if (line == null)
                        continue;

                    // 將原始行加入清單框
                    salesListBox.Items.Add(line);

                    // 先嘗試直接解析整行（若檔案只有數字）
                    if (decimal.TryParse(line, NumberStyles.Number, CultureInfo.InvariantCulture, out currentSales) ||
                        decimal.TryParse(line, out currentSales))
                    {
                        totalSales += currentSales;  // 加到總銷售額
                        continue;
                    }

                    // 否則嘗試從行中擷取數字（例如: "1月 1000.0"）
                    var match = Regex.Match(line, "-?\\d+(\\.\\d+)?");
                    if (match.Success)
                    {
                        if (decimal.TryParse(match.Value, NumberStyles.Number, CultureInfo.InvariantCulture, out currentSales) ||
                            decimal.TryParse(match.Value, out currentSales))
                        {
                            totalSales += currentSales;  // 加到總銷售額
                            continue;
                        }
                    }

                    // 若仍無法解析，顯示錯誤但繼續處理其餘行
                    MessageBox.Show("無法解析銷售額: " + line);
                }
                inputFile.Close();  // 關閉檔案
                totalLabel.Text = totalSales.ToString("C"); // 顯示總銷售額
            }
           else
            {
                // 使用者取消檔案選擇
                MessageBox.Show("未選擇任何檔案。");



            }
            
            }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
