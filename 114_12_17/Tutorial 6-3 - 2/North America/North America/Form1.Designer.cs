namespace North_America
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.getCountriesButton = new System.Windows.Forms.Button();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.countriesListBox = new System.Windows.Forms.ListBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            // 結束按鈕：使用者按下後關閉表單。
            // 已將文字改為繁體中文，字型改為 18，並放大按鈕以配合較大字型。
            this.exitButton.Location = new System.Drawing.Point(220, 230);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 50);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // getCountriesButton
            // 
            // 取得國家按鈕：觸發開啟檔案並將內容顯示於清單內的動作。
            // 已將文字改為繁體中文，字型改為 18，並放大按鈕以配合較大字型。
            this.getCountriesButton.Location = new System.Drawing.Point(40, 230);
            this.getCountriesButton.Name = "getCountriesButton";
            this.getCountriesButton.Size = new System.Drawing.Size(140, 50);
            this.getCountriesButton.TabIndex = 6;
            this.getCountriesButton.Text = "取得國家";
            this.getCountriesButton.UseVisualStyleBackColor = true;
            this.getCountriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCountriesButton.Click += new System.EventHandler(this.getCountriesButton_Click);
            // 
            // outputDescriptionLabel
            // 
            // 說明標籤：顯示此清單所列出的內容描述。
            // 將文字改為繁體中文並使用粗體 18pt 以提升可讀性，保留 AutoSize 讓標籤依內容自適應寬度。
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(12, 12);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(220, 29);
            this.outputDescriptionLabel.TabIndex = 5;
            this.outputDescriptionLabel.Text = "北美洲的國家";
            // 
            // countriesListBox
            // 
            // 國家清單：顯示檔案中讀取的國家清單。字型改為 18 以配合整體介面大小。
            // 已放大清單的寬高並調整位置，確保項目與按鈕間距適當。
            this.countriesListBox.FormattingEnabled = true;
            this.countriesListBox.Location = new System.Drawing.Point(20, 55);
            this.countriesListBox.Name = "countriesListBox";
            this.countriesListBox.Size = new System.Drawing.Size(340, 150);
            this.countriesListBox.TabIndex = 4;
            this.countriesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Form1
            // 
            // 表單：將標題文字改為繁體中文，並擴大視窗以容納放大的控制項與字型。
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getCountriesButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.countriesListBox);
            this.Name = "Form1";
            this.Text = "北美洲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button getCountriesButton;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.ListBox countriesListBox;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

