namespace Change_Counter
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具產生的欄位：元件容器。
        /// 這個欄位由設計器管理，用來保存表單中所使用的非視覺元件（例如 Timer、ImageList 等）。
        /// 如果在執行 Dispose 時 disposing 為 true，且 components 不為 null，則釋放它們。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除所有使用中的資源。
        /// disposing = true 表示由使用者程式呼叫（需要釋放托管與非托管資源）。
        /// disposing = false 表示由垃圾回收器呼叫（只應釋放非托管資源）。
        /// 設計器產生的程式通常只需保留這段標準實作。
        /// </summary>
        /// <param name="disposing">是否要釋放託管資源</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 此方法由 Windows Form 設計工具自動產生，用來初始化表單上所有控制項。
        /// 注意：
        /// - 一般不建議手動修改此方法內的程式碼，因為設計工具可能會覆寫修改。
        /// - 若需要調整控制項行為或事件處理，請在程式碼後置 (Form1.cs) 新增或修改事件處理程式。
        /// 下面我以繁體中文加入詳細註解，說明設計工具程式碼做了哪些事。
        /// </summary>
        private void InitializeComponent()
        {
            // 建立各控制項的實例（但尚未完成屬性設定）
            this.instructionLabel = new System.Windows.Forms.Label();
            this.fiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.tenCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.twentyFiveCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.fiftyCentsPictureBox = new System.Windows.Forms.PictureBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.outputDescription = new System.Windows.Forms.Label();

            // BeginInit / EndInit 是部分控制項 (如 PictureBox、DataGridView 等) 在序列化時
            // 的初始與結束訊號，讓控制項在設定所有屬性期間不會即時重繪或驗證。
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).BeginInit();

            // 暫停表單的版面配置更新，等所有控制項屬性設定完再 ResumeLayout()
            this.SuspendLayout();

            // 
            // instructionLabel
            // 
            // 說明用 Label，提示使用者可點擊畫面上的硬幣圖片。
            // Font 設為 22pt 粗體以符合要求（字型大小統一為 22）。
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(82, 9);
            this.instructionLabel.Name = "instructionLabel";
            // Size 有時由 AutoSize 自動計算；設計器仍會保留此行以供參考。
            this.instructionLabel.Size = new System.Drawing.Size(246, 36);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "請點擊硬幣"; // 繁體中文介面文字

            // 
            // fiveCentsPictureBox
            // 
            // 5 分硬幣的圖片盒（PictureBox）。
            // Image 屬性引用專案資源 (Properties.Resources._5cents)。
            // SizeMode 設為 AutoSize，會依圖片實際大小調整控制項尺寸。
            this.fiveCentsPictureBox.Image = global::Change_Counter.Properties.Resources._5cents;
            this.fiveCentsPictureBox.Location = new System.Drawing.Point(12, 60);
            this.fiveCentsPictureBox.Name = "fiveCentsPictureBox";
            this.fiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiveCentsPictureBox.TabIndex = 1;
            this.fiveCentsPictureBox.TabStop = false;
            // 將 Click 事件綁到 Form1.cs 中的事件處理方法（由程式邏輯負責更新總額）
            this.fiveCentsPictureBox.Click += new System.EventHandler(this.fiveCentsPictureBox_Click);

            // 
            // tenCentsPictureBox
            // 
            // 10 分硬幣的圖片盒。
            this.tenCentsPictureBox.Image = global::Change_Counter.Properties.Resources._10cents;
            this.tenCentsPictureBox.Location = new System.Drawing.Point(144, 60);
            this.tenCentsPictureBox.Name = "tenCentsPictureBox";
            this.tenCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.tenCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.tenCentsPictureBox.TabIndex = 2;
            this.tenCentsPictureBox.TabStop = false;
            // Click 事件綁定：處理使用者點擊 10 分的行為
            this.tenCentsPictureBox.Click += new System.EventHandler(this.tenCentsPictureBox_Click);

            // 
            // twentyFiveCentsPictureBox
            // 
            // 25 分硬幣的圖片盒。
            this.twentyFiveCentsPictureBox.Image = global::Change_Counter.Properties.Resources._25cents;
            this.twentyFiveCentsPictureBox.Location = new System.Drawing.Point(12, 247);
            this.twentyFiveCentsPictureBox.Name = "twentyFiveCentsPictureBox";
            this.twentyFiveCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.twentyFiveCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.twentyFiveCentsPictureBox.TabIndex = 3;
            this.twentyFiveCentsPictureBox.TabStop = false;
            // Click 事件綁定：處理使用者點擊 25 分的行為
            this.twentyFiveCentsPictureBox.Click += new System.EventHandler(this.twentyFiveCentsPictureBox_Click);

            // 
            // fiftyCentsPictureBox
            // 
            // 50 分硬幣的圖片盒。
            this.fiftyCentsPictureBox.Image = global::Change_Counter.Properties.Resources._50cents;
            this.fiftyCentsPictureBox.Location = new System.Drawing.Point(144, 247);
            this.fiftyCentsPictureBox.Name = "fiftyCentsPictureBox";
            this.fiftyCentsPictureBox.Size = new System.Drawing.Size(125, 181);
            this.fiftyCentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.fiftyCentsPictureBox.TabIndex = 4;
            this.fiftyCentsPictureBox.TabStop = false;
            // Click 事件綁定：處理使用者點擊 50 分的行為
            this.fiftyCentsPictureBox.Click += new System.EventHandler(this.fiftyCentsPictureBox_Click);

            // 
            // exitButton
            // 
            // 離開按鈕：字型調整為 22pt 以符合 UI 視覺統一性。
            // 按下時會觸發 Form1.cs 中的 exitButton_Click，通常會呼叫 Close() 關閉表單。
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(160, 460);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 40);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "離開"; // 繁體中文文字
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);

            // 
            // totalLabel
            // 
            // 顯示總計的 Label，字型也設為 22pt，並以框線突顯結果欄位。
            // 初始文字設定為 NT$0.00，可由程式動態更新為當前總額（Form1.cs 的 UpdateTotalLabel）。
            this.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(281, 206);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(120, 40);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.totalLabel.Text = "NT$0.00"; // 初始顯示本地貨幣格式，可以在程式中更新

            // 
            // outputDescription
            // 
            // 總計文字標籤（描述欄位用途），使用粗體並設為 22pt。
            this.outputDescription.AutoSize = true;
            this.outputDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescription.Location = new System.Drawing.Point(301, 170);
            this.outputDescription.Name = "outputDescription";
            this.outputDescription.Size = new System.Drawing.Size(80, 36);
            this.outputDescription.TabIndex = 7;
            this.outputDescription.Text = "總計"; // 繁體中文文字

            // 
            // Form1 (表單整體設定)
            // 
            // AutoScaleDimensions 與 AutoScaleMode 控制 DPI / 字型縮放行為。
            // ClientSize 設定表單的初始畫布大小；增加高度以容納放大後的字型與控制項。
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 520);

            // 將控制項加入表單 Controls 集合（加入順序影響 TabIndex 與 Z-order）
            this.Controls.Add(this.outputDescription);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.fiftyCentsPictureBox);
            this.Controls.Add(this.twentyFiveCentsPictureBox);
            this.Controls.Add(this.tenCentsPictureBox);
            this.Controls.Add(this.fiveCentsPictureBox);
            this.Controls.Add(this.instructionLabel);

            // 表單基本屬性設定（標題文字改為繁體中文）
            this.Name = "Form1";
            this.Text = "零錢計數器";

            // EndInit：通知那些支援 ISupportInitialize 的控制項，初始化已完成
            ((System.ComponentModel.ISupportInitialize)(this.fiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyFiveCentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftyCentsPictureBox)).EndInit();

            // 恢復表單版面配置更新，並且執行必要的佈局與繪製
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // 下列為表單上使用的欄位宣告。
        // 注意：設計工具會根據檢視器上的控制項自動更新這些欄位。
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.PictureBox fiveCentsPictureBox;
        private System.Windows.Forms.PictureBox tenCentsPictureBox;
        private System.Windows.Forms.PictureBox twentyFiveCentsPictureBox;
        private System.Windows.Forms.PictureBox fiftyCentsPictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label outputDescription;
    }
}

