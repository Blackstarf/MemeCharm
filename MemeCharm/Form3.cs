using System.Media;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace MemeCharm
{
    public partial class MemeGenerate : Form
    {
        private TrackBar trackBar1;
        public static Image img2;
        public string imgPath2;
        public string input;
        Bitmap t;
        public MemeGenerate(Bitmap obrez, string imgPath)
        {
            imgPath2 = imgPath;
            t = obrez;
            InitializeComponent();
            pictureBox1.Image = img2;
            // Скрываем кнопку 3 при инициализации формы
            button3.Visible = false;
            button5.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = DataPicture.imageMeme;
            Bitmap bitmap = new Bitmap(DataPicture.imageMeme);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private bool trackBarValueChanged = false; // Переменная для отслеживания изменений в ползунке

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer("Resource\\bomb.wav");
            player.Play();
            // Создаем и настраиваем динамический TrackBar
            trackBar1 = new TrackBar();
            trackBar1.Location = new Point(50, 50); // Укажите координаты расположения TrackBar
            trackBar1.Size = new Size(200, 20); // Укажите размер TrackBar
            trackBar1.Minimum = 0; // Установите минимальное значение
            trackBar1.Maximum = 100; // Установите максимальное значение
            trackBar1.TickStyle = TickStyle.None; // Уберите отображение делений, если нужно
            trackBar1.Scroll += DynamicTrackBar_Scroll; // Подписываемся на событие Scroll

            // Показываем кнопку 3
            button5.Visible = true;

            // Добавляем TrackBar на форму
            this.Controls.Add(trackBar1);

            // Устанавливаем фокус на TrackBar
            trackBar1.Focus();
        }

        private void DynamicTrackBar_Scroll(object sender, EventArgs e)
        {
            // Устанавливаем значение переменной в true, когда пользователь перемещает ползунок
            trackBarValueChanged = true;
        }

        private Bitmap Vertolet(string transparency)
        {
            if (string.IsNullOrWhiteSpace(transparency))
            {
                // Если строка пустая, вернуть пустое изображение или выполнить другие необходимые действия
                return new Bitmap(1, 1);
            }

            // Загрузка фотографии
            Bitmap backgroundImage = new Bitmap(imgPath2);
            // Загрузите две картинки
            Bitmap overlayImage = new Bitmap(@"C:\Users\B-ZONE\OneDrive\Рабочий стол\MemeCharm\MemeCharm\Resources\Вьетнам.png"); // Пусть overlayImage имеет прозрачный фон

            // Создайте новое изображение для комбинации фонового и наложенного изображений
            Bitmap combinedImage = new Bitmap(backgroundImage.Width, backgroundImage.Height);

            // Используйте Graphics для рисования изображений
            using (Graphics g = Graphics.FromImage(combinedImage))
            {
                // Нарисуйте фоновое изображение
                g.DrawImage(backgroundImage, Point.Empty);

                // Создайте объект ImageAttributes для установки прозрачности наложенного изображения
                ImageAttributes imageAttributes = new ImageAttributes();

                // Попробуйте парсить значение
                if (float.TryParse(transparency, out float transparencyValue))
                {
                    // Установите альфа-канал (прозрачность) для наложенного изображения (здесь 0.5 означает 50% прозрачности)
                    ColorMatrix matrix = new ColorMatrix();
                    matrix.Matrix33 = transparencyValue; // Установка альфа-канала
                    imageAttributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    // Нарисуйте наложенное изображение с установленной прозрачностью
                    g.DrawImage(overlayImage, new Rectangle(Point.Empty, backgroundImage.Size), 0, 0, overlayImage.Width, overlayImage.Height, GraphicsUnit.Pixel, imageAttributes);
                }
                else
                {
                    // Если не удалось распарсить значение, вернуть пустое изображение или выполнить другие необходимые действия
                    return new Bitmap(1, 1);
                }
            }

            // Отобразите комбинированное изображение
            return combinedImage;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Проверяем, изменилось ли значение ползунка
            if (trackBarValueChanged)
            {
                // Получаем измененное изображение с надписью
                Bitmap processedImage = Vertolet(((float)trackBar1.Value / 100).ToString());

                // Устанавливаем измененное изображение в PictureBox
                pictureBox1.Image = processedImage;

                // Сохраняем изображение в переменной img2
                img2 = pictureBox1.Image;
                Image image = pictureBox1.Image;
                if (image != null)
                {
                    img2 = image;
                    DataPicture.imageMeme = img2;
                    MemeCharm.img3 = image;
                }
                //Закрываем текущее окно
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                int choices = rnd.Next(0, 5);
                switch (choices)
                {
                    case 0:
                        SoundPlayer player = new SoundPlayer("Resource\\fart.wav");
                        player.Play();

                        break;
                    case 1:
                        SoundPlayer player1 = new SoundPlayer("Resource\\among.wav");
                        player1.Play();
                        break;
                    case 2:
                        SoundPlayer player2 = new SoundPlayer("Resource\\dubstem.wav");
                        player2.Play();
                        break;
                    case 3:
                        SoundPlayer player3 = new SoundPlayer("Resource\\movie_1.wav");
                        player3.Play();
                        break;

                    case 4:
                        SoundPlayer player4 = new SoundPlayer("Resource\\m-e-o-w.wav");
                        player4.Play();
                        break;
                }
                // Закрываем текущее окно
                Close();
            }
        }

        private void DynamicTextBoxBlack(object sender, KeyEventArgs e)
        {
            // Удаляем обработчик события KeyDown, чтобы не обрабатывать Enter
            input = textBox2.Text;
            textBox2.KeyDown -= DynamicTextBoxBlack;

            // Условие для срабатывания только при нажатии на Enter удаляем
        }

        private Bitmap ProcessImage(string captionText)
        {
            // Загрузка фотографии
            Bitmap photo = new Bitmap(imgPath2);

            // Определение размера черного фона с отступами
            int borderSize = 200; // Отступы по 200 пикселей с каждой стороны
            int backgroundWidth = photo.Width + 2 * borderSize;
            int backgroundHeight = photo.Height + 2 * borderSize;

            // Создание черного фона с отступами
            Bitmap image = new Bitmap(backgroundWidth, backgroundHeight);
            using (Graphics g = Graphics.FromImage(image))
            {
                // Заливаем фон чёрным цветом
                using (Brush brush = new SolidBrush(Color.Black))
                {
                    g.FillRectangle(brush, 0, 0, backgroundWidth, backgroundHeight);
                }

                // Рассчитываем координаты для центрирования фотографии с учетом рамки
                int x = borderSize; // Горизонтальный отступ для рамки
                int y = borderSize; // Вертикальный отступ для рамки

                // Добавляем рамку вокруг фотографии
                int borderWidth = 5;
                using (Pen pen = new Pen(Color.White, borderWidth))
                {
                    g.DrawRectangle(pen, new Rectangle(x, y, photo.Width + borderWidth, photo.Height + borderWidth));
                }

                // Рисуем фотографию внутри рамки
                g.DrawImage(photo, new Rectangle(x + borderWidth, y + borderWidth, photo.Width, photo.Height));

                // Добавляем надпись под рамкой
                using (Font font = new Font("Arial", 60)) // Увеличенный размер шрифта на 40
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    // Рассчитываем координаты для надписи
                    int captionX = backgroundWidth / 2;
                    int captionY = y + photo.Height + borderWidth + 50; // Под рамкой с отступом 50 пикселей

                    // Рисуем надпись
                    g.DrawString(captionText, font, Brushes.White, captionX, captionY, sf);
                }
            }

            // Возвращаем измененное изображение
            return image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получаем измененное изображение с надписью
            Bitmap processedImage = ProcessImage(textBox2.Text);

            // Устанавливаем измененное изображение в PictureBox
            pictureBox1.Image = processedImage;

            // Сохраняем изображение в переменной img2
            img2 = pictureBox1.Image;
            Image image = pictureBox1.Image;
            if (image != null)
            {
                img2 = image;
                DataPicture.imageMeme = img2;
                MemeCharm.img3 = image;
            }
            // Закрываем текущее окно
            Close();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            // Создаем и настраиваем динамический TextBox
            textBox2 = new TextBox();
            textBox2.Location = new Point(283, 50); // Укажите координаты расположения TextBox
            textBox2.Size = new Size(200, 40); // Укажите размер TextBox
            textBox2.KeyDown += DynamicTextBoxBlack; // Подписываемся на событие KeyDown

            // Показываем кнопку 3
            button3.Visible = true;

            // Добавляем TextBox на форму
            this.Controls.Add(textBox2);

            // Устанавливаем фокус на TextBox
            textBox2.Focus();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Путь к первому изображению
            string imagePath1 = @"D:\Programs\projects\MemeCharm\MemeCharm\Resource\Ronaldo.png";

            // Загружаем первое изображение
            Bitmap firstImage = new Bitmap(imagePath1);
            pictureBox1.Image = firstImage;

            // Загружаем второе изображение
            Bitmap secondImage = new Bitmap(imgPath2);
            pictureBox2.Image = secondImage;

            // Масштабируем второе изображение до размера 320x300 пикселей
            Bitmap scaledSecondImage = new Bitmap(320, 300);
            using (Graphics g = Graphics.FromImage(scaledSecondImage))
            {
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                g.DrawImage(secondImage, 0, 0, 320, 300);
            }

            // Создаем новое изображение для объединения
            int combinedWidth = Math.Max(firstImage.Width, scaledSecondImage.Width); // Берем максимальную ширину изображений
            int combinedHeight = firstImage.Height + scaledSecondImage.Height + 100; // Высота объединенного изображения, увеличиваем на 100 пикселей
            Bitmap combinedImage = new Bitmap(combinedWidth, combinedHeight);

            using (Graphics g = Graphics.FromImage(combinedImage))
            {
                // Рисуем второе изображение (из imgPath2) на переднем фоне и опускаем на 100 пикселей вниз
                g.DrawImage(scaledSecondImage, new Point(0, 70));

                // Рисуем первое изображение (Роналдо) поверх второго
                g.DrawImage(firstImage, new Point(0, 0));
            }

            // Отображаем объединенное изображение в pictureBox1
            pictureBox1.Image = combinedImage;

            // Сохраняем изображение в переменной img2
            img2 = pictureBox1.Image;
            Image image = pictureBox1.Image;
            if (image != null)
            {
                img2 = image;
                DataPicture.imageMeme = img2;
                MemeCharm.img3 = image;
            }

            // Закрываем текущее окно
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int choices = rnd.Next(0, 5);
            switch (choices)
            {
                case 0:
                    SoundPlayer player = new SoundPlayer("Resource\\fart.wav");
                    player.Play();

                    break;
                case 1:
                    SoundPlayer player1 = new SoundPlayer("Resource\\among.wav");
                    player1.Play();
                    break;
                case 2:
                    SoundPlayer player2 = new SoundPlayer("Resource\\dubstem.wav");
                    player2.Play();
                    break;
                case 3:
                    SoundPlayer player3 = new SoundPlayer("Resource\\movie_1.wav");
                    player3.Play();
                    break;

                case 4:
                    SoundPlayer player4 = new SoundPlayer("Resource\\m-e-o-w.wav");
                    player4.Play();
                    break;
            }
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
