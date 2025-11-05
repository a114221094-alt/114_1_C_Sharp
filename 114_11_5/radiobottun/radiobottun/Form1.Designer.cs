namespace radiobottun
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            mikuteaButton4 = new RadioButton();
            radteaButton3 = new RadioButton();
            jcyButton2 = new RadioButton();
            cfbutton = new RadioButton();
            groupBox2 = new GroupBox();
            jambutton = new RadioButton();
            hambutton = new RadioButton();
            tunaradioButton5 = new RadioButton();
            sendbutton = new Button();
            leavebutton2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mikuteaButton4);
            groupBox1.Controls.Add(radteaButton3);
            groupBox1.Controls.Add(jcyButton2);
            groupBox1.Controls.Add(cfbutton);
            groupBox1.Location = new Point(12, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(290, 338);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "飲料";
            // 
            // mikuteaButton4
            // 
            mikuteaButton4.AutoSize = true;
            mikuteaButton4.Location = new Point(110, 127);
            mikuteaButton4.Name = "mikuteaButton4";
            mikuteaButton4.Size = new Size(71, 27);
            mikuteaButton4.TabIndex = 7;
            mikuteaButton4.TabStop = true;
            mikuteaButton4.Text = "奶茶";
            mikuteaButton4.UseVisualStyleBackColor = true;
            // 
            // radteaButton3
            // 
            radteaButton3.AutoSize = true;
            radteaButton3.Location = new Point(110, 187);
            radteaButton3.Name = "radteaButton3";
            radteaButton3.Size = new Size(71, 27);
            radteaButton3.TabIndex = 6;
            radteaButton3.TabStop = true;
            radteaButton3.Text = "紅茶";
            radteaButton3.UseVisualStyleBackColor = true;
            // 
            // jcyButton2
            // 
            jcyButton2.AutoSize = true;
            jcyButton2.Location = new Point(110, 240);
            jcyButton2.Name = "jcyButton2";
            jcyButton2.Size = new Size(71, 27);
            jcyButton2.TabIndex = 5;
            jcyButton2.TabStop = true;
            jcyButton2.Text = "果汁";
            jcyButton2.UseVisualStyleBackColor = true;
            // 
            // cfbutton
            // 
            cfbutton.AutoSize = true;
            cfbutton.Location = new Point(110, 71);
            cfbutton.Name = "cfbutton";
            cfbutton.Size = new Size(71, 27);
            cfbutton.TabIndex = 4;
            cfbutton.TabStop = true;
            cfbutton.Text = "咖啡";
            cfbutton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(jambutton);
            groupBox2.Controls.Add(hambutton);
            groupBox2.Controls.Add(tunaradioButton5);
            groupBox2.Location = new Point(344, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(279, 323);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "三明治";
            // 
            // jambutton
            // 
            jambutton.AutoSize = true;
            jambutton.Location = new Point(77, 206);
            jambutton.Name = "jambutton";
            jambutton.Size = new Size(125, 27);
            jambutton.TabIndex = 9;
            jambutton.TabStop = true;
            jambutton.Text = "果醬三明治";
            jambutton.UseVisualStyleBackColor = true;
            // 
            // hambutton
            // 
            hambutton.AutoSize = true;
            hambutton.Location = new Point(77, 146);
            hambutton.Name = "hambutton";
            hambutton.Size = new Size(125, 27);
            hambutton.TabIndex = 8;
            hambutton.TabStop = true;
            hambutton.Text = "火腿三明治";
            hambutton.UseVisualStyleBackColor = true;
            // 
            // tunaradioButton5
            // 
            tunaradioButton5.AutoSize = true;
            tunaradioButton5.Location = new Point(77, 90);
            tunaradioButton5.Name = "tunaradioButton5";
            tunaradioButton5.Size = new Size(125, 27);
            tunaradioButton5.TabIndex = 7;
            tunaradioButton5.TabStop = true;
            tunaradioButton5.Text = "鮪魚三明治";
            tunaradioButton5.UseVisualStyleBackColor = true;
            // 
            // sendbutton
            // 
            sendbutton.Location = new Point(113, 391);
            sendbutton.Name = "sendbutton";
            sendbutton.Size = new Size(112, 34);
            sendbutton.TabIndex = 9;
            sendbutton.Text = "送出訂單";
            sendbutton.UseVisualStyleBackColor = true;
            sendbutton.Click += sendbutton_Click;
            // 
            // leavebutton2
            // 
            leavebutton2.Location = new Point(421, 391);
            leavebutton2.Name = "leavebutton2";
            leavebutton2.Size = new Size(112, 34);
            leavebutton2.TabIndex = 10;
            leavebutton2.Text = "離開";
            leavebutton2.UseVisualStyleBackColor = true;
            leavebutton2.Click += leavebutton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(leavebutton2);
            Controls.Add(sendbutton);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton mikuteaButton4;
        private RadioButton radteaButton3;
        private RadioButton jcyButton2;
        private RadioButton cfbutton;
        private GroupBox groupBox2;
        private RadioButton jambutton;
        private RadioButton hambutton;
        private RadioButton tunaradioButton5;
        private Button sendbutton;
        private Button leavebutton2;
    }
}
