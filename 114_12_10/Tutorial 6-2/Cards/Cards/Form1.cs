using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    /// <summary>
    /// 主視窗表單類別：負責處理卡片選取與顯示相關的互動邏輯。
    /// 注意：UI 控制項 (例如 cardListBox、showCardButton、exitButton) 定義於 Form1.Designer.cs。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Form 的建構子。InitializeComponent() 會建立並初始化所有由設計工具產生的控制項。
        /// 呼叫此方法是 WinForms 表單正確顯示與運作的必要步驟。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 顯示所選卡片按鈕的 Click 事件處理器。
        /// 當使用者按下按鈕時，檢查 ListBox 是否有選取項目，
        /// 若有則將選取項目的文字傳給 showselectedcard 進行處理；若無則提示使用者選取卡片。
        /// </summary>
        /// <param name="sender">事件來源（通常為按鈕本身）</param>
        /// <param name="e">事件參數</param>
        private void showCardButton_Click(object sender, EventArgs e)
        {
            // ListBox.SelectedIndex 會回傳目前選取項目的索引，若為 -1 表示尚未選取任何項目。
            if (cardListBox.SelectedIndex != -1)
            {
                // SelectedItem 可能為 null（雖然在 SelectedIndex != -1 時一般不會），
                // 這裡先呼叫 ToString() 取得該項目的顯示文字，並傳入處理函式。
                showselectedcard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                // 若沒有選取任何項目，顯示對話窗提醒使用者。
                // MessageBox.Show 為同步呼叫，會暫停目前執行緒直到使用者關閉對話窗。
                MessageBox.Show("Please select a card from the list.");
            }
        }

        /// <summary>
        /// 根據傳入的卡片名稱執行相對應的顯示或處理邏輯。
        /// 目前範例以 switch 分支為基礎，未實作實際顯示內容，可在對應 case 填入顯示或更新 UI 的程式碼。
        /// </summary>
        /// <param name="cardName">卡片的名稱（通常為 ListBox 的項目文字）</param>
            private void showselectedcard(string cardName)
        {
            // 使用 switch 以字串比對不同的卡片名稱，根據不同名稱執行不同處理。
            // 若未命中任何 case，會落到 default 分支（可用來處理未知或未實作的項目）。
            switch (cardName)
            {
                case "黑陶A":
                    // 範例：在此處放入顯示「Ace of Spades」卡片的程式碼，例如：
                    // pictureBox.Image = Properties.Resources.AceOfSpades;
                    // labelCardName.Text = "Ace of Spades";
                    showacespade();
                    break;
                case "紅心10":
                    // 範例：顯示 2 of Hearts 的相關 UI 更新
                    Showtenoheart();
                    break;
                case "梅花K":
                    // 範例：顯示 3 of Diamonds 的相關 UI 更新
                    showkingclub();
                    break;
                
                default:
                    // 如果傳入未知的 cardName，可在此處處理錯誤或顯示預設內容。
                    // 例如：顯示一個訊息或載入一張預設卡片圖片。
                    MessageBox.Show("Selected card is not recognized.");
                    break;
            }
        }

        private void showacespade()
        {
            aceSpadesPictureBox.Visible = true;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = false;
        }
        private void Showtenoheart()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = true;
            kingClubsPictureBox.Visible = false;
        }

        private void showkingclub()
        {
            aceSpadesPictureBox.Visible = false;
            tenHeartsPictureBox.Visible = false;
            kingClubsPictureBox.Visible = true;
        }
        /// <summary>
        /// 離開按鈕的 Click 事件處理器，關閉當前表單。
        /// this.Close() 會觸發表單的關閉流程，若為應用程式主要視窗，可能會結束應用程式。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單視窗；若此表單是主視窗（Application.Run 的目標），整個應用程式將會結束。
            this.Close();
        }
    }
}
