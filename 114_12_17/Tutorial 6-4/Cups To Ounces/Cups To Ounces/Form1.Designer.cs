namespace Cups_To_Ounces
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 釋放資源。
        /// </summary>
        /// <param name="disposing">如果為 true，表示管理的資源應被釋放。</param>
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
        /// 初始化表單及其控制項。
        /// - 將所有顯示文字改為繁體中文。
        /// - 將顯示字型統一設為 18pt，以利閱讀。
        /// - 調整元件大小與相對位置，使在較大字型下版面仍整齊。
        /// 注意：此處僅變更外觀屬性與註解，功能事件綁定維持不變。
        /// </summary>
        private void InitializeComponent()
        {
            this.bannerLabel = new System.Windows.Forms.Label();
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            this.ouncesLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            // 功能說明標題：顯示應用程式用途（已翻譯為繁體中文）
            // 使用粗體 18pt 字型以強調標題
            this.bannerLabel.AutoSize = true;
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannerLabel.Location = new System.Drawing.Point(12, 12);
            this.bannerLabel.Name = "bannerLabel";
            this.bannerLabel.Size = new System.Drawing.Size(260, 29);
            this.bannerLabel.TabIndex = 0;
            this.bannerLabel.Text = "杯數轉盎司換算器";
            // 
            // cupsPromptLabel
            // 
            // 輸入欄位提示：使用繁體中文「杯數：」
            // 將字型改為 18pt，並靠左對齊輸入框
            this.cupsPromptLabel.AutoSize = true;
            this.cupsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cupsPromptLabel.Location = new System.Drawing.Point(30, 62);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.Size = new System.Drawing.Size(88, 29);
            this.cupsPromptLabel.TabIndex = 1;
            this.cupsPromptLabel.Text = "杯數：";
            // 
            // cupsTextBox
            // 
            // 使用者輸入杯數的文字方塊
            // 字型改為 18pt，以符合整體視覺比例，並增高輸入框以容納較大字型
            this.cupsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cupsTextBox.Location = new System.Drawing.Point(140, 60);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(140, 35);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel
            // 
            // 顯示換算結果（盎司）
            // 使用邊框標示，並置中顯示結果文字；字型改為 18pt
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ouncesLabel.Location = new System.Drawing.Point(140, 105);
            this.ouncesLabel.Name = "ouncesLabel";
            this.ouncesLabel.Size = new System.Drawing.Size(140, 38);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            // 結果標籤：描述顯示欄位（已翻譯為繁體中文「流體盎司：」）
            // 字型改為 18pt，對齊結果顯示欄位
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(30, 110);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(130, 29);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "流體盎司：";
            // 
            // convertButton
            // 
            // 按鈕：執行轉換動作（Text 改為「轉換」）
            // 字型改為 18pt，按鈕尺寸放大以利點選
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.convertButton.Location = new System.Drawing.Point(50, 160);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(120, 44);
            this.convertButton.TabIndex = 5;
            this.convertButton.Text = "轉換";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            // 按鈕：關閉表單（Text 改為「離開」）
            // 字型改為 18pt，尺寸與位置與轉換按鈕對齊
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.exitButton.Location = new System.Drawing.Point(200, 160);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 44);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 表單基本屬性：適當放大 ClientSize 以容納 18pt 字型的元件
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 230);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Name = "Form1";
            this.Text = "杯數轉盎司";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label cupsPromptLabel;
        private System.Windows.Forms.TextBox cupsTextBox;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

