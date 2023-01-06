using System;
using System.Drawing;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {

        int _x;
        int _y;
        bool _mouseClicked = false;
        int ImW, ImH;

        Brush _selectedBrush;

        Color SelectedColor
        {
            get { return colorDialog1.Color; }
        }

        Color DefaultColor
        {
            get { return Color.White; }
        }

        int SelectedSize
        {
            get { return trackBar1.Value; }
        }



        public Form1()
        {
            InitializeComponent();
        }

        void CreateBlank(int width, int height)
        {
            try
            {
                var oldImage = pictureBox1.Image;
                var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        bmp.SetPixel(i, j, DefaultColor);
                    }
                }

                pictureBox1.Image = bmp;
                if (oldImage != null)
                {
                    oldImage.Dispose();
                }
            }

            catch (Exception)
            {

            }
        }

       // private void button1_Click(object sender, EventArgs e)
       // {
       //     _selectedBrush = new QuadBrush(SelectedColor, SelectedSize); 
       // }

        private void button2_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Circle(SelectedColor, SelectedSize);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Spray(SelectedColor, SelectedSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Eraser(SelectedColor, SelectedSize);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _selectedBrush.Size = trackBar1.Value;
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

        /*private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }*/

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
                        MessageBox.Show("Íåâîçìîæíî ñîõðàíèòü èçîáðàæåíèå", "Îøèáêà",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBlank(ImW, ImH);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _selectedBrush.cColor = ((Button)sender).BackColor;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedBrush.cColor = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
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
    }
}
