namespace MemeCharm
{
    partial class Form2
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
            Button button4;
            Button CloseButton;
            label1 = new Label();
            Obrez = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ButtonOK = new Button();
            button4 = new Button();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Obrez).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button4.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = Properties.Resources._3;
            button4.Location = new Point(741, 1);
            button4.Name = "button4";
            button4.Size = new Size(22, 21);
            button4.TabIndex = 9;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = Properties.Resources.X;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseDownBackColor = Color.Red;
            CloseButton.FlatAppearance.MouseOverBackColor = Color.Red;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.Location = new Point(770, 1);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(22, 21);
            CloseButton.TabIndex = 8;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(358, 35);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "Обрезка изображения";
            // 
            // Obrez
            // 
            Obrez.Image = Properties.Resources.LogoV3;
            Obrez.Location = new Point(29, 81);
            Obrez.Name = "Obrez";
            Obrez.Size = new Size(294, 284);
            Obrez.SizeMode = PictureBoxSizeMode.Zoom;
            Obrez.TabIndex = 1;
            Obrez.TabStop = false;
            Obrez.Click += Obrez_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.LogoV31;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(283, 284);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.MouseDownBackColor = Color.Maroon;
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(351, 102);
            button1.Name = "button1";
            button1.Size = new Size(137, 42);
            button1.TabIndex = 3;
            button1.Text = "Обрезать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.MouseDownBackColor = Color.Maroon;
            button2.FlatAppearance.MouseOverBackColor = Color.Gray;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(351, 178);
            button2.Name = "button2";
            button2.Size = new Size(137, 42);
            button2.TabIndex = 4;
            button2.Text = "Подтвердить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(505, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(283, 284);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(82, 82, 82);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(CloseButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 22);
            panel2.TabIndex = 7;
            panel2.MouseDown += panel2_MouseDown;
            panel2.MouseMove += panel2_MouseMove;
            // 
            // ButtonOK
            // 
            ButtonOK.Location = new Point(413, 390);
            ButtonOK.Name = "ButtonOK";
            ButtonOK.Size = new Size(65, 38);
            ButtonOK.TabIndex = 8;
            ButtonOK.Text = "OK";
            ButtonOK.UseVisualStyleBackColor = true;
            ButtonOK.Click += ButtonOK_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonOK);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Obrez);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)Obrez).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox Obrez;
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Button ButtonOK;
    }
}