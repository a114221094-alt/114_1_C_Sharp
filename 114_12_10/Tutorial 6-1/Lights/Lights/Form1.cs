using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    /// <summary>
    /// 主視窗表單：控制燈的開關顯示（使用兩個 PictureBox 與一個 Label）
    /// - lightOnPictureBox: 顯示「開燈」圖片
    /// - lightOffPictureBox: 顯示「關燈」圖片
    /// - lightStateLabel: 顯示文字狀態 ("on" / "off")
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件（由 Designer 產生的 InitializeComponent 負責建立控制項與事件綁定）
        /// 呼叫 InitializeComponent 以載入 Form 的子控制項與屬性設定。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 切換按鈕的 Click 事件處理器：
        /// 根據目前的圖片可見性來切換燈的狀態（若顯示開燈圖則關燈，反之則開燈）。
        /// sender 與 e 為標準事件參數（通常由 Designer 自動連結）。
        /// </summary>
        private void switchButton_Click(object sender, EventArgs e)
        {
            // 以 Visible 屬性決定目前顯示的是哪一張圖片
            if (lightOnPictureBox.Visible == true)
            {
                // 若目前顯示開燈圖，則執行關燈邏輯
                turnlightoff();
            }
            else
            {
                // 否則顯示開燈
                turnlighton();
            }
        }

        /// <summary>
        /// 將介面切換為「開燈」狀態：
        /// - 顯示開燈圖片（lightOnPictureBox）
        /// - 隱藏關燈圖片（lightOffPictureBox）
        /// - 更新狀態標籤為 "on"
        /// 注意：此方法只操作 UI 元件的屬性，不處理任何硬體或外部狀態。
        /// </summary>
        private void turnlighton()
        {
            // 顯示「燈開」的圖片
            lightOnPictureBox.Visible = true;
            // 隱藏「燈關」的圖片（確保畫面上只會看到單一狀態）
            lightOffPictureBox.Visible = false;
            // 更新文字標籤，方便使用者或程式邏輯讀取當前狀態
            lightStateLabel.Text = "on";
        }

        /// <summary>
        /// 將介面切換為「關燈」狀態：
        /// - 顯示關燈圖片（lightOffPictureBox）
        /// - 隱藏開燈圖片（lightOnPictureBox）
        /// - 更新狀態標籤為 "off"
        /// </summary>
        private void turnlightoff()
        {
            // 隱藏「燈開」圖片
            lightOnPictureBox.Visible = false;
            // 顯示「燈關」圖片
            lightOffPictureBox.Visible = true;
            // 更新狀態文字
            lightStateLabel.Text = "off";
        }

        /// <summary>
        /// 離開按鈕的 Click 事件處理器：關閉目前表單。
        /// this.Close() 會觸發表單關閉流程，若為應用程式主窗體則會結束程式。
        /// 若需要在關閉前做額外確認或釋放資源，可在此或 FormClosing 事件加入邏輯。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉目前表單（會觸發 FormClosing / FormClosed 事件）
            this.Close();
        }

        /// <summary>
        /// lightStateLabel 的 Click 事件佈局（目前未實作任何行為）
        /// 保留此方法可讓 Designer 仍然綁定到事件；若不需要請從 Designer 移除綁定或刪除此方法。
        /// </summary>
        private void lightStateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
