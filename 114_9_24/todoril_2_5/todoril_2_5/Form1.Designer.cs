namespace todoril_2_5
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
            cardfacepictureBox = new PictureBox();
            cardbackpictureBox = new PictureBox();
            showbackbutton = new Button();
            showfacebutton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardfacepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardbackpictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardfacepictureBox
            // 
            cardfacepictureBox.Image = (Image)resources.GetObject("cardfacepictureBox.Image");
            cardfacepictureBox.Location = new Point(257, 55);
            cardfacepictureBox.Name = "cardfacepictureBox";
            cardfacepictureBox.Size = new Size(181, 281);
            cardfacepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardfacepictureBox.TabIndex = 0;
            cardfacepictureBox.TabStop = false;
            // 
            // cardbackpictureBox
            // 
            cardbackpictureBox.Image = (Image)resources.GetObject("cardbackpictureBox.Image");
            cardbackpictureBox.Location = new Point(257, 55);
            cardbackpictureBox.Name = "cardbackpictureBox";
            cardbackpictureBox.Size = new Size(181, 281);
            cardbackpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardbackpictureBox.TabIndex = 1;
            cardbackpictureBox.TabStop = false;
            cardbackpictureBox.Click += pictureBox2_Click;
            // 
            // showbackbutton
            // 
            showbackbutton.Location = new Point(516, 135);
            showbackbutton.Name = "showbackbutton";
            showbackbutton.Size = new Size(112, 34);
            showbackbutton.TabIndex = 2;
            showbackbutton.Text = "顯示背面";
            showbackbutton.UseVisualStyleBackColor = true;
            showbackbutton.Click += showbackbutton_Click;
            // 
            // showfacebutton
            // 
            showfacebutton.Location = new Point(516, 257);
            showfacebutton.Name = "showfacebutton";
            showfacebutton.Size = new Size(112, 34);
            showfacebutton.TabIndex = 3;
            showfacebutton.Text = "顯示正面";
            showfacebutton.UseVisualStyleBackColor = true;
            showfacebutton.Click += showfacebutton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showfacebutton);
            Controls.Add(showbackbutton);
            Controls.Add(cardbackpictureBox);
            Controls.Add(cardfacepictureBox);
            Name = "Form1";
            Text = "翻轉撲克牌";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cardfacepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardbackpictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardfacepictureBox;
        private PictureBox cardbackpictureBox;
        private Button showbackbutton;
        private Button showfacebutton;
    }
}
