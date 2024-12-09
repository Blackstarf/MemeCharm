namespace MemeCharm
{
    partial class MemeCharm
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
            components = new System.ComponentModel.Container();
            Button CloseButton;
            Button button2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemeCharm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            eyecenter = new PictureBox();
            GeneradeMeme = new Button();
            Obrezka = new Button();
            Jmih = new Button();
            sidebaer = new FlowLayoutPanel();
            panel2 = new Panel();
            label1 = new Label();
            menuButton = new PictureBox();
            PanelForHomebutton = new Panel();
            HomeButton = new Button();
            panel4 = new Panel();
            HelpButton = new Button();
            panel5 = new Panel();
            AboutButton = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            CloseButton = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eyecenter).BeginInit();
            sidebaer.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            PanelForHomebutton.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
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
            CloseButton.Location = new Point(995, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(22, 21);
            CloseButton.TabIndex = 0;
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button2.FlatAppearance.MouseOverBackColor = Color.Cyan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = Properties.Resources._3;
            button2.Location = new Point(967, 4);
            button2.Name = "button2";
            button2.Size = new Size(22, 21);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(82, 82, 82);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 26);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.LogoV3;
            pictureBox1.Location = new Point(9, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 21);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // eyecenter
            // 
            eyecenter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eyecenter.BackgroundImageLayout = ImageLayout.Center;
            eyecenter.BorderStyle = BorderStyle.FixedSingle;
            eyecenter.Cursor = Cursors.Hand;
            eyecenter.Image = Properties.Resources.photo_2024_03_17_00_46_28;
            eyecenter.Location = new Point(224, 198);
            eyecenter.Name = "eyecenter";
            eyecenter.Size = new Size(565, 360);
            eyecenter.SizeMode = PictureBoxSizeMode.Zoom;
            eyecenter.TabIndex = 1;
            eyecenter.TabStop = false;
            eyecenter.Click += pictureBox1_Click;
            // 
            // GeneradeMeme
            // 
            GeneradeMeme.Cursor = Cursors.Hand;
            GeneradeMeme.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            GeneradeMeme.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            GeneradeMeme.FlatStyle = FlatStyle.Flat;
            GeneradeMeme.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            GeneradeMeme.Location = new Point(408, 93);
            GeneradeMeme.Name = "GeneradeMeme";
            GeneradeMeme.Size = new Size(191, 59);
            GeneradeMeme.TabIndex = 2;
            GeneradeMeme.Text = "Сгенерировать мем";
            GeneradeMeme.UseVisualStyleBackColor = true;
            GeneradeMeme.Click += GeneradeMeme_Click;
            // 
            // Obrezka
            // 
            Obrezka.Cursor = Cursors.Hand;
            Obrezka.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Obrezka.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            Obrezka.FlatStyle = FlatStyle.Flat;
            Obrezka.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Obrezka.Location = new Point(224, 654);
            Obrezka.Name = "Obrezka";
            Obrezka.Size = new Size(191, 59);
            Obrezka.TabIndex = 3;
            Obrezka.Text = "Обрезка";
            Obrezka.UseVisualStyleBackColor = true;
            Obrezka.Click += Obrezka_Click;
            // 
            // Jmih
            // 
            Jmih.Cursor = Cursors.Hand;
            Jmih.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            Jmih.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 0, 0);
            Jmih.FlatStyle = FlatStyle.Flat;
            Jmih.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Jmih.Location = new Point(598, 654);
            Jmih.Name = "Jmih";
            Jmih.Size = new Size(191, 59);
            Jmih.TabIndex = 3;
            Jmih.Text = "ЖМЫХ";
            Jmih.UseVisualStyleBackColor = true;
            Jmih.Click += Jmih_Click;
            // 
            // sidebaer
            // 
            sidebaer.BackColor = Color.FromArgb(64, 64, 64);
            sidebaer.Controls.Add(panel2);
            sidebaer.Controls.Add(PanelForHomebutton);
            sidebaer.Controls.Add(panel4);
            sidebaer.Controls.Add(panel5);
            sidebaer.Dock = DockStyle.Left;
            sidebaer.Location = new Point(0, 26);
            sidebaer.MaximumSize = new Size(173, 742);
            sidebaer.MinimumSize = new Size(40, 742);
            sidebaer.Name = "sidebaer";
            sidebaer.Size = new Size(40, 742);
            sidebaer.TabIndex = 4;
            sidebaer.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(menuButton);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 95);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 1;
            label1.Text = "Меню";
            // 
            // menuButton
            // 
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.menu1;
            menuButton.Location = new Point(4, 33);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(29, 25);
            menuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            menuButton.TabIndex = 0;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // PanelForHomebutton
            // 
            PanelForHomebutton.Controls.Add(HomeButton);
            PanelForHomebutton.Location = new Point(3, 104);
            PanelForHomebutton.Name = "PanelForHomebutton";
            PanelForHomebutton.Size = new Size(197, 57);
            PanelForHomebutton.TabIndex = 1;
            // 
            // HomeButton
            // 
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.ForeColor = Color.White;
            HomeButton.Image = Properties.Resources.SaveImage_копия;
            HomeButton.ImageAlign = ContentAlignment.MiddleLeft;
            HomeButton.Location = new Point(-1, -7);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(173, 67);
            HomeButton.TabIndex = 0;
            HomeButton.Text = "        Сохранить  ";
            HomeButton.TextAlign = ContentAlignment.MiddleLeft;
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += button1_Click_3;
            // 
            // panel4
            // 
            panel4.Controls.Add(HelpButton);
            panel4.Location = new Point(3, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 57);
            panel4.TabIndex = 2;
            // 
            // HelpButton
            // 
            HelpButton.FlatStyle = FlatStyle.Flat;
            HelpButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            HelpButton.ForeColor = Color.White;
            HelpButton.Image = Properties.Resources.help;
            HelpButton.ImageAlign = ContentAlignment.MiddleLeft;
            HelpButton.Location = new Point(-1, -7);
            HelpButton.Name = "HelpButton";
            HelpButton.Size = new Size(173, 67);
            HelpButton.TabIndex = 0;
            HelpButton.Text = "        О Программе ";
            HelpButton.TextAlign = ContentAlignment.MiddleLeft;
            HelpButton.UseVisualStyleBackColor = true;
            HelpButton.Click += HelpButton_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(AboutButton);
            panel5.Location = new Point(3, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 57);
            panel5.TabIndex = 2;
            // 
            // AboutButton
            // 
            AboutButton.FlatStyle = FlatStyle.Flat;
            AboutButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            AboutButton.ForeColor = Color.White;
            AboutButton.Image = Properties.Resources.eyeabout;
            AboutButton.ImageAlign = ContentAlignment.MiddleLeft;
            AboutButton.Location = new Point(-2, -7);
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(173, 67);
            AboutButton.TabIndex = 0;
            AboutButton.Text = "        Больше  ";
            AboutButton.TextAlign = ContentAlignment.MiddleLeft;
            AboutButton.UseVisualStyleBackColor = true;
            AboutButton.Click += AboutButton_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 10;
            sidebartimer.Tick += timerone_Tick;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.BorderRadius = 30;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // MemeCharm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1024, 768);
            Controls.Add(sidebaer);
            Controls.Add(Jmih);
            Controls.Add(Obrezka);
            Controls.Add(GeneradeMeme);
            Controls.Add(eyecenter);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MemeCharm";
            StartPosition = FormStartPosition.CenterParent;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)eyecenter).EndInit();
            sidebaer.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            PanelForHomebutton.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox eyecenter;
        private Button CloseButton;
        private PictureBox pictureBox1;
        private Button GeneradeMeme;
        private Button Obrezka;
        private Button Jmih;
        private FlowLayoutPanel sidebaer;
        private Panel panel2;
        private Panel PanelForHomebutton;
        private Button HomeButton;
        private Panel panel4;
        private Button HelpButton;
        private Panel panel5;
        private Button AboutButton;
        private PictureBox menuButton;
        private Label label1;
        private System.Windows.Forms.Timer sidebartimer;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}