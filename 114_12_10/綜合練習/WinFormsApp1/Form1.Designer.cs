namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Added control declarations
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelQuiz1;
        private System.Windows.Forms.Label labelQuiz2;
        private System.Windows.Forms.Label labelQuiz3;
        private System.Windows.Forms.Label labelResult;

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.TextBox txtQuiz3;

        private System.Windows.Forms.Button btnShowHighest;
        private System.Windows.Forms.Button btnExit;

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
            labelLastName = new Label();
            labelFirstName = new Label();
            labelQuiz1 = new Label();
            labelQuiz2 = new Label();
            labelQuiz3 = new Label();
            labelResult = new Label();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtQuiz1 = new TextBox();
            txtQuiz2 = new TextBox();
            txtQuiz3 = new TextBox();
            btnShowHighest = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // labelLastName
            // 
            labelLastName.Font = new Font("Segoe UI", 22F);
            labelLastName.Location = new Point(22, 28);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(74, 75);
            labelLastName.TabIndex = 0;
            labelLastName.Text = "姓";
            labelLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelFirstName
            // 
            labelFirstName.Font = new Font("Segoe UI", 22F);
            labelFirstName.Location = new Point(382, 28);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(100, 50);
            labelFirstName.TabIndex = 2;
            labelFirstName.Text = "名";
            labelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuiz1
            // 
            labelQuiz1.Font = new Font("Segoe UI", 22F);
            labelQuiz1.Location = new Point(12, 103);
            labelQuiz1.Name = "labelQuiz1";
            labelQuiz1.Size = new Size(150, 72);
            labelQuiz1.TabIndex = 4;
            labelQuiz1.Text = "小考1";
            labelQuiz1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuiz2
            // 
            labelQuiz2.Font = new Font("Segoe UI", 22F);
            labelQuiz2.Location = new Point(12, 187);
            labelQuiz2.Name = "labelQuiz2";
            labelQuiz2.Size = new Size(150, 65);
            labelQuiz2.TabIndex = 6;
            labelQuiz2.Text = "小考2";
            labelQuiz2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelQuiz3
            // 
            labelQuiz3.Font = new Font("Segoe UI", 22F);
            labelQuiz3.Location = new Point(12, 252);
            labelQuiz3.Name = "labelQuiz3";
            labelQuiz3.Size = new Size(151, 104);
            labelQuiz3.TabIndex = 8;
            labelQuiz3.Text = "小考3";
            labelQuiz3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelResult
            // 
            labelResult.BorderStyle = BorderStyle.Fixed3D;
            labelResult.Font = new Font("Segoe UI", 22F);
            labelResult.Location = new Point(433, 174);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(454, 163);
            labelResult.TabIndex = 10;
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 22F);
            txtLastName.Location = new Point(462, 37);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(211, 66);
            txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 22F);
            txtFirstName.Location = new Point(120, 32);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(236, 66);
            txtFirstName.TabIndex = 3;
            // 
            // txtQuiz1
            // 
            txtQuiz1.Font = new Font("Segoe UI", 22F);
            txtQuiz1.Location = new Point(169, 109);
            txtQuiz1.Name = "txtQuiz1";
            txtQuiz1.Size = new Size(210, 66);
            txtQuiz1.TabIndex = 5;
            // 
            // txtQuiz2
            // 
            txtQuiz2.Font = new Font("Segoe UI", 22F);
            txtQuiz2.Location = new Point(168, 187);
            txtQuiz2.Name = "txtQuiz2";
            txtQuiz2.Size = new Size(211, 66);
            txtQuiz2.TabIndex = 7;
            // 
            // txtQuiz3
            // 
            txtQuiz3.Font = new Font("Segoe UI", 22F);
            txtQuiz3.Location = new Point(157, 271);
            txtQuiz3.Name = "txtQuiz3";
            txtQuiz3.Size = new Size(223, 66);
            txtQuiz3.TabIndex = 9;
            // 
            // btnShowHighest
            // 
            btnShowHighest.Font = new Font("Segoe UI", 22F);
            btnShowHighest.Location = new Point(120, 403);
            btnShowHighest.Name = "btnShowHighest";
            btnShowHighest.Size = new Size(260, 80);
            btnShowHighest.TabIndex = 11;
            btnShowHighest.Text = "顯示最高分";
            btnShowHighest.UseVisualStyleBackColor = true;
            btnShowHighest.Click += btnShowHighest_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 22F);
            btnExit.Location = new Point(526, 403);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(260, 80);
            btnExit.TabIndex = 12;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 520);
            Controls.Add(labelLastName);
            Controls.Add(txtLastName);
            Controls.Add(labelFirstName);
            Controls.Add(txtFirstName);
            Controls.Add(labelQuiz1);
            Controls.Add(txtQuiz1);
            Controls.Add(labelQuiz2);
            Controls.Add(txtQuiz2);
            Controls.Add(labelQuiz3);
            Controls.Add(txtQuiz3);
            Controls.Add(labelResult);
            Controls.Add(btnShowHighest);
            Controls.Add(btnExit);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
