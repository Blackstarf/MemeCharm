using System.Media;
using Python.Runtime;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.Diagnostics;

namespace MemeCharm
{
    public partial class MemeCharm : Form
    {

        public static Image img3;
        string imgPath;
        Graphics myGraphics;
        Bitmap myBitmapObrez;
        Bitmap MyGen;

        public MemeCharm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(1024, 768);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        Point mousepoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mousepoint.X;
                this.Top += e.Y - mousepoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousepoint = new Point(e.X, e.Y);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //������ ������������ �����
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    eyecenter.Image = new Bitmap(dlg.FileName);
                    Image image = eyecenter.Image;
                    DataPicture.imageMeme = image;
                    Form2.img2 = DataPicture.imageMeme;
                    imgPath = dlg.FileName;
                    //MessageBox.Show(image, "������", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                }
                catch
                {
                    MessageBox.Show("���� �� ������� ������ �������� ������", "������", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public async void PythonJmix()
        {
            await Task.Run(() =>
            {// �������������� ������������� CPython
                PythonEngine.Initialize();
                static string GetImageFormat(byte[] byteArray)
                {
                    using (MemoryStream ms = new MemoryStream(byteArray))
                    {
                        try
                        {
                            using (Image img = Image.FromStream(ms))
                            {
                                // �������� ������ �����������
                                return img.RawFormat.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred while getting image format: " + ex.Message);
                            return null;
                        }
                    }
                    
                }
                // ������� ����� ������������� Python
                using (Py.GIL()) // ����������� GIL (Global Interpreter Lock)
                {
                    dynamic sys = Py.Import("sys");

                    // ��������� ���� � ����������� Python
                    string pathToPythonLibs = @"D:\Programs\projects\MemeCharm\MemeCharm\Resource\Lib\";
                    sys.path.append(pathToPythonLibs);

                    // ��������� ������ Python
                    dynamic module = Py.Import("qwer");

                    // ��� ������ ������
                    byte[] byteArray = module.Jmix(imgPath);

                    // ������� ����� ������ �� ������� ������
                    using (MemoryStream stream = new MemoryStream(byteArray))
                    {
                        try
                        {
                            // ��������� ����������� �� ������
                            img3 = Image.FromStream(stream);

                            // �������� ������ �����������
                            string imageFormat = GetImageFormat(byteArray);

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occurred: " + ex.Message);
                        }
                    }


                    eyecenter.Image = img3;
                    SoundPlayer player = new SoundPlayer("Resource\\fart.wav");
                    player.Play();
                }

            });
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void GeneradeMeme_Click(object sender, EventArgs e)
        {
            //// �������� ����������
            //Bitmap photo = new Bitmap(@"C:\Users\B-ZONE\OneDrive\������� ����\MemeCharm\MemeCharm\Resources\photo.jpg");
            //// �������� ����������
            //Bitmap image = new Bitmap(photo.Width - 500, photo.Height - 700); // �������� 60 �������� �� ������ � 80 �������� �� ������
            //using (Graphics g = Graphics.FromImage(image))
            //{
            //    // �������� ��� ������ ������
            //    g.Clear(Color.Black);

            //    // ��������� ���������� � 2 ����
            //    Bitmap smallPhoto = new Bitmap(photo, new Size(photo.Width / 2, photo.Height / 2));

            //    // ������������ ���������� ��� ������������� ���������� � �������
            //    int x = (image.Width - smallPhoto.Width) / 2;
            //    int y = (image.Height - smallPhoto.Height) / 2 - 20; // ��������� �������� �����

            //    // ��������� ����������� ���������� � ������
            //    int borderWidth = 5;
            //    using (Pen pen = new Pen(Color.White, borderWidth))
            //    {
            //        g.DrawRectangle(pen, new Rectangle(x - borderWidth / 2, y - borderWidth / 2, smallPhoto.Width + borderWidth, smallPhoto.Height + borderWidth));
            //    }
            //    g.DrawImage(smallPhoto, new Point(x, y)); // ������� �������� ����������

            //    // ��������� ������� ��� ����������� �����������
            //    string captionText = "Your caption text here";
            //    using (Font font = new Font("Arial", 40)) // ����������� ������ ������ �� 40
            //    using (StringFormat sf = new StringFormat())
            //    {
            //        sf.Alignment = StringAlignment.Center;
            //        sf.LineAlignment = StringAlignment.Center;

            //        // ������������ ������������ ���������� ��� �������
            //        int captionY = y + smallPhoto.Height + borderWidth + 10;

            //        // ������������ ������ �������
            //        SizeF textSize = g.MeasureString(captionText, font, image.Width);
            //        int captionHeight = (int)Math.Ceiling(textSize.Height);

            //        // ���� ������ ������� ������ ���������� ������������, ��������� ���������� y
            //        if (captionY + captionHeight > image.Height)
            //        {
            //            captionY = image.Height - captionHeight - 5; // ��������� ������ �� ������� ���� �����������
            //        }

            //        // ������ �������
            //        g.DrawString(captionText, font, Brushes.White, new Rectangle(0, captionY, image.Width, captionHeight), sf);
            //    }
            //}

            //// ��������� ����������� � ��������
            //image.Save(@"C:\Users\B-ZONE\OneDrive\������� ����\MemeCharm\MemeCharm\Resources\photo2.jpg", ImageFormat.Jpeg);
            //Random rnd = new Random(Guid.NewGuid().GetHashCode());
            //int choices = rnd.Next(0, 5);

            //switch (choices)
            //{
            //    case 0:
            //        SoundPlayer player = new SoundPlayer("Resource\\fart.wav");
            //        player.Play();

            //        break;
            //    case 1:
            //        SoundPlayer player1 = new SoundPlayer("Resource\\among.wav");
            //        player1.Play();
            //        break;
            //    case 2:
            //        SoundPlayer player2 = new SoundPlayer("Resource\\dubstem.wav");
            //        player2.Play();
            //        break;
            //    case 3:
            //        SoundPlayer player3 = new SoundPlayer("Resource\\movie_1.wav");
            //        player3.Play();
            //        break;

            //    case 4:
            //        SoundPlayer player4 = new SoundPlayer("Resource\\m-e-o-w.wav");
            //        player4.Play();
            //        break;
            //}
            MemeGenerate Gen = new MemeGenerate(MyGen, imgPath);
            Gen.ShowDialog();
            eyecenter.Image = img3;
            img3 = DataPicture.imageMeme;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Jmih_Click(object sender, EventArgs e)
        {
            eyecenter.Image = Image.FromFile("Resource\\load.gif");
            PythonJmix();
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Obrezka_Click(object sender, EventArgs e)
        {
            Form2 obrez = new Form2(myBitmapObrez);
            obrez.ShowDialog();
            eyecenter.Image = img3;
            img3 = DataPicture.imageMeme;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            // �������� ����� ��� ���������� �����
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPEG Image|*.jpg|PNG Image|*.png|BMP Image|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // �������� ���� � ������������ �����
                string filePath = saveFileDialog.FileName;
                // �������� ���������� �����
                string fileExtension = Path.GetExtension(filePath);
                // ��������� ����������� � ��������� �������
                switch (fileExtension.ToLowerInvariant())
                {
                    case ".jpg":

                    case ".jpeg":
                        img3.Save(filePath, ImageFormat.Jpeg);
                        break;
                    case ".png":
                        img3.Save(filePath, ImageFormat.Png);
                        break;
                    case ".bmp":
                        img3.Save(filePath, ImageFormat.Bmp);
                        break;
                    default:
                        MessageBox.Show("���������������� ������ �����!");
                        break;
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        bool sidebarExpand;
        private void timerone_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebaer.Width -= 10;
                if (sidebaer.Width == sidebaer.MinimumSize.Width)
                {

                    sidebarExpand = false;
                    sidebartimer.Stop();
                }
            }
            else
            {
                sidebaer.Width += 10;
                if (sidebaer.Width == sidebaer.MaximumSize.Width)
                {

                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void panelAnimated(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://youtu.be/JB8HABQQiLw",
                UseShellExecute = true
            });
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutwin = new AboutBox1();
            aboutwin.ShowDialog();
        }
    }
}