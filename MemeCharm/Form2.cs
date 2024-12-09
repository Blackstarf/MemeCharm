using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemeCharm
{
    public partial class Form2 : Form
    {
        public static Image img2;

        Bitmap t;
        public Form2(Bitmap obrez)
        {
            t = obrez;
            InitializeComponent();
            Obrez.Image = img2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Obrez.Image = DataPicture.imageMeme;
            Bitmap bitmap = new Bitmap(DataPicture.imageMeme);
            Obrez.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Obrez.MouseDown += new MouseEventHandler(Obrez_MouseDown);

            Obrez.MouseMove += new MouseEventHandler(Obrez_MouseMove);

            Obrez.MouseEnter += new EventHandler(Obrez_MouseEnter);
            Controls.Add(Obrez);
        }
        int crpX, crpY, rectW, rectH;
        public Pen crpPen = new Pen(Color.White);
        private void Obrez_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                crpX = e.X;
                crpY = e.Y;

            }
        }
        private void Obrez_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }
        private void Obrez_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                Obrez.Refresh();
                rectW = e.X - crpX;
                rectH = e.Y - crpY;
                Graphics g = Obrez.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.Default;
                Bitmap bmp2 = new Bitmap(Obrez.Width, Obrez.Height);
                Obrez.DrawToBitmap(bmp2, Obrez.ClientRectangle);

                Bitmap crpImg = new Bitmap(rectW, rectH);

                for (int i = 0; i < rectW; i++)
                {
                    for (int j = 0; j < rectH; j++)
                    {
                        Color pxlclr = bmp2.GetPixel(crpX + i, crpY + j);
                        crpImg.SetPixel(i, j, pxlclr);
                    }
                }
                pictureBox2.Image = (Image)crpImg;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                MessageBox.Show("Сначало обрежте фотографию", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void Obrez_Click(object sender, EventArgs e)
        {
            //Obrez.Image = DataPicture.imageMeme;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point mousepoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousepoint.X;
                this.Top += e.Y - mousepoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mousepoint = new Point(e.X, e.Y);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Image image = pictureBox2.Image;
            if (image != null)
            {
                img2 = image;
                DataPicture.imageMeme = img2;
                MemeCharm.img3 = image;
            }
            this.Close();
        }
    }
}
