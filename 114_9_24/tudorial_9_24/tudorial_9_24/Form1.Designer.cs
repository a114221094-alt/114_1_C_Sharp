namespace tudorial_9_24
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Conutrylebel = new Label();
            finlandpictureBox = new PictureBox();
            francepictureBox = new PictureBox();
            germanypictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)finlandpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)francepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)germanypictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 111);
            label1.Name = "label1";
            label1.Size = new Size(208, 23);
            label1.TabIndex = 0;
            label1.Text = "點選國旗會出現國家名稱";
            // 
            // Conutrylebel
            // 
            Conutrylebel.BackColor = SystemColors.ButtonFace;
            Conutrylebel.BorderStyle = BorderStyle.FixedSingle;
            Conutrylebel.Location = new Point(202, 321);
            Conutrylebel.Name = "Conutrylebel";
            Conutrylebel.Size = new Size(363, 99);
            Conutrylebel.TabIndex = 1;
            Conutrylebel.TextAlign = ContentAlignment.MiddleCenter;
            Conutrylebel.Click += conutrylebel_Click;
            this.Conutrylebel.Font = new System.Drawing.Font(this.Conutrylebel.Font.FontFamily, 24F, this.Conutrylebel.Font.Style);
            // 
            // finlandpictureBox
            // 
            finlandpictureBox.Image = Properties.Resources.Finland;
            finlandpictureBox.Location = new Point(33, 181);
            finlandpictureBox.Name = "finlandpictureBox";
            finlandpictureBox.Size = new Size(150, 75);
            finlandpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            finlandpictureBox.TabIndex = 2;
            finlandpictureBox.TabStop = false;
            finlandpictureBox.Click += finlandpictureBox_Click;
            // 
            // francepictureBox
            // 
            francepictureBox.Image = (Image)resources.GetObject("francepictureBox.Image");
            francepictureBox.Location = new Point(305, 181);
            francepictureBox.Name = "francepictureBox";
            francepictureBox.Size = new Size(150, 75);
            francepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            francepictureBox.TabIndex = 3;
            francepictureBox.TabStop = false;
            francepictureBox.Click += francepictureBox_Click;
            // 
            // germanypictureBox
            // 
            germanypictureBox.Image = (Image)resources.GetObject("germanypictureBox.Image");
            germanypictureBox.Location = new Point(562, 181);
            germanypictureBox.Name = "germanypictureBox";
            germanypictureBox.Size = new Size(150, 75);
            germanypictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            germanypictureBox.TabIndex = 4;
            germanypictureBox.TabStop = false;
            germanypictureBox.Click += germanypictureBox_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(germanypictureBox);
            Controls.Add(francepictureBox);
            Controls.Add(finlandpictureBox);
            Controls.Add(Conutrylebel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)finlandpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)francepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)germanypictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Conutrylebel;
        private PictureBox finlandpictureBox;
        private PictureBox francepictureBox;
        private PictureBox germanypictureBox;
    }
}
