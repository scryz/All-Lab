using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        int _x;
        int _y;
        

        bool _mouseClicked = false;
        Color SelectedColor
        {
            get { return colorDialog1.Color; }
        }
        int SelectedSize
        {
            get { return trackBar1.Value; }
        }
        Brush _selecredBrush;
        Color DefaultColor
        {
            get { return Color.White; }
        }
        void CreateBlank(int width, int height)
        {
            var OldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (OldImage != null)
            {
                OldImage.Dispose();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            CreateBlank(screenWidth, screenHeight);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _selecredBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (_selecredBrush == null)
            {
                return;
            }
            _selecredBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                try
                {
                    _selecredBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                }
                catch
                {

                }
                pictureBox1.Refresh();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _selecredBrush = new Circle(SelectedColor, SelectedSize);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (_selecredBrush == null)
            {
                MessageBox.Show("Выберите кисть!");
            }
            else
            {
                _selecredBrush.Size = trackBar1.Value;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_selecredBrush == null)
            {
                MessageBox.Show("Выберите кисть!");
            }
            else
            {
                _selecredBrush.BrushColor = ((Button)sender).BackColor;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button5.BackColor = colorDialog1.Color;
                if (colorDialog1.Color == Color.Black)
                {
                    button5.ForeColor = Color.White;
                }
            }
            if (_selecredBrush == null)
            {
                MessageBox.Show("Выберите кисть!");
            }
            else
            {
                _selecredBrush.BrushColor = colorDialog1.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _selecredBrush = new Eraser(SelectedColor, SelectedSize);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Версия упрощённого Paint:\nv.1.0.0",
        "О программе",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {

                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.OverwritePrompt = true;
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("При сохранении приозошла ошибка!", "Ошибка!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _selecredBrush = new SlashL(SelectedColor, SelectedSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _selecredBrush = new Spray(SelectedColor, SelectedSize);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            _selecredBrush = new Flower(SelectedColor, SelectedSize);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            CreateBlank(screenWidth, screenHeight);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            _selecredBrush = new Krug(SelectedColor, SelectedSize);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            _selecredBrush = new SlashR(SelectedColor, SelectedSize);
        }
    }
}
