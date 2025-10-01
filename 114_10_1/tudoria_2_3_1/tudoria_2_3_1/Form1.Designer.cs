namespace tudoria_2_3_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dayofweekTextbox = new System.Windows.Forms.TextBox();
            this.monthTextbox = new System.Windows.Forms.TextBox();
            this.dayofmonthTextbox = new System.Windows.Forms.TextBox();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.dateoutputlabel = new System.Windows.Forms.Label();
            this.showdatebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(89, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "星期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(89, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "月:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(89, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 40);
            this.label4.TabIndex = 3;
            this.label4.Text = "年:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(89, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "日:";
            // 
            // dayofweekTextbox
            // 
            this.dayofweekTextbox.Location = new System.Drawing.Point(219, 65);
            this.dayofweekTextbox.Name = "dayofweekTextbox";
            this.dayofweekTextbox.Size = new System.Drawing.Size(281, 29);
            this.dayofweekTextbox.TabIndex = 5;
            // 
            // monthTextbox
            // 
            this.monthTextbox.Location = new System.Drawing.Point(219, 139);
            this.monthTextbox.Name = "monthTextbox";
            this.monthTextbox.Size = new System.Drawing.Size(281, 29);
            this.monthTextbox.TabIndex = 6;
            // 
            // dayofmonthTextbox
            // 
            this.dayofmonthTextbox.Location = new System.Drawing.Point(219, 213);
            this.dayofmonthTextbox.Name = "dayofmonthTextbox";
            this.dayofmonthTextbox.Size = new System.Drawing.Size(281, 29);
            this.dayofmonthTextbox.TabIndex = 7;
            // 
            // yearTextbox
            // 
            this.yearTextbox.Location = new System.Drawing.Point(219, 293);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(281, 29);
            this.yearTextbox.TabIndex = 8;
            // 
            // dateoutputlabel
            // 
            this.dateoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateoutputlabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateoutputlabel.Location = new System.Drawing.Point(88, 361);
            this.dateoutputlabel.Name = "dateoutputlabel";
            this.dateoutputlabel.Size = new System.Drawing.Size(412, 80);
            this.dateoutputlabel.TabIndex = 9;
            // 
            // showdatebutton
            // 
            this.showdatebutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showdatebutton.Location = new System.Drawing.Point(563, 64);
            this.showdatebutton.Name = "showdatebutton";
            this.showdatebutton.Size = new System.Drawing.Size(190, 59);
            this.showdatebutton.TabIndex = 10;
            this.showdatebutton.Text = "顯示日期";
            this.showdatebutton.UseVisualStyleBackColor = true;
            this.showdatebutton.Click += new System.EventHandler(this.showdatebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitbutton.Location = new System.Drawing.Point(563, 269);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(190, 59);
            this.exitbutton.TabIndex = 11;
            this.exitbutton.Text = "離開";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearbutton.Location = new System.Drawing.Point(563, 162);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(190, 59);
            this.clearbutton.TabIndex = 12;
            this.clearbutton.Text = "清除";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.showdatebutton);
            this.Controls.Add(this.dateoutputlabel);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.dayofmonthTextbox);
            this.Controls.Add(this.monthTextbox);
            this.Controls.Add(this.dayofweekTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dayofweekTextbox;
        private System.Windows.Forms.TextBox monthTextbox;
        private System.Windows.Forms.TextBox dayofmonthTextbox;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.Label dateoutputlabel;
        private System.Windows.Forms.Button showdatebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button clearbutton;
    }
}

