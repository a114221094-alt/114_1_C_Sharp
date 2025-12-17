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

            decimal[] sales = new decimal[8]; // 儲存銷售額陣列
            int index = 0; // 陣列索引

            try
            {
                inputFile = File.OpenText("Sales.txt");  // 開啟檔案
                //salesListBox.Items.Clear(); // 清除清單框內容

                while (!inputFile.EndOfStream)  // 讀取直到檔案結尾
                {
                    if (decimal.TryParse( line = inputFile.ReadLine(), out currentSales) )
                    {
                        salesListBox.Items.Add(line); // 將銷售額加入清單框                     
                        sales[index] = currentSales; // 將銷售額存入陣列
                        index++;
                    }
                    else
                    {
                        MessageBox.Show("無法解析銷售額: " + line);
                        break;
                    }
                }
                inputFile.Close();  // 關閉檔案
                

                for (int i = 0; i < index; i++)
                {
                    totalSales += sales[i]; // 計算總銷售額
                }

                totalLabel.Text = totalSales.ToString("C"); // 顯示總銷售額
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;  // 宣告輸入檔案物件
            string line; // 儲存讀取的行
            try
                {
                inputFile = File.OpenText("Sales.txt");  // 開啟檔案
                salesListBox.Items.Clear(); // 清除清單框內容
                while (!inputFile.EndOfStream)  // 讀取直到檔案結尾
                {
                    line = inputFile.ReadLine();
                    salesListBox.Items.Add(line); // 將銷售額加入清單框                     
                }
                inputFile.Close();  // 關閉檔案
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }
    }
}
