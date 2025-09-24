namespace tudorial_2_3
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.translationlabel = new System.Windows.Forms.Label();
            this.idalianbutton = new System.Windows.Forms.Button();
            this.spanishbutton = new System.Windows.Forms.Button();
            this.germanbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(226, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我會說早安";
            // 
            // translationlabel
            // 
            this.translationlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.translationlabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translationlabel.Location = new System.Drawing.Point(228, 157);
            this.translationlabel.Name = "translationlabel";
            this.translationlabel.Size = new System.Drawing.Size(346, 162);
            this.translationlabel.TabIndex = 1;
            this.translationlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idalianbutton
            // 
            this.idalianbutton.Location = new System.Drawing.Point(176, 377);
            this.idalianbutton.Name = "idalianbutton";
            this.idalianbutton.Size = new System.Drawing.Size(104, 35);
            this.idalianbutton.TabIndex = 2;
            this.idalianbutton.Text = "義大利文";
            this.idalianbutton.UseVisualStyleBackColor = true;
            this.idalianbutton.Click += new System.EventHandler(this.idalianbutton_Click);
            // 
            // spanishbutton
            // 
            this.spanishbutton.Location = new System.Drawing.Point(361, 377);
            this.spanishbutton.Name = "spanishbutton";
            this.spanishbutton.Size = new System.Drawing.Size(92, 35);
            this.spanishbutton.TabIndex = 3;
            this.spanishbutton.Text = "西班牙文";
            this.spanishbutton.UseVisualStyleBackColor = true;
            this.spanishbutton.Click += new System.EventHandler(this.spanishbutton_Click);
            // 
            // germanbutton
            // 
            this.germanbutton.Location = new System.Drawing.Point(562, 377);
            this.germanbutton.Name = "germanbutton";
            this.germanbutton.Size = new System.Drawing.Size(83, 35);
            this.germanbutton.TabIndex = 4;
            this.germanbutton.Text = "德文";
            this.germanbutton.UseVisualStyleBackColor = true;
            this.germanbutton.Click += new System.EventHandler(this.germanbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.germanbutton);
            this.Controls.Add(this.spanishbutton);
            this.Controls.Add(this.idalianbutton);
            this.Controls.Add(this.translationlabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "語言翻譯器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translationlabel;
        private System.Windows.Forms.Button idalianbutton;
        private System.Windows.Forms.Button spanishbutton;
        private System.Windows.Forms.Button germanbutton;
    }
}

