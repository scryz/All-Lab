using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace simple_paint
{
    
    public partial class Form1 : Form
    {
        
        int _x;
        int _y;
        bool _mouseClicked = false;


        int ImW, ImH;

        Color SelectedColor
        {
            get { return Color.Black; }
        }


        int SelectedSize
        {
            get { return trackBar1.Value; }
        }

        Brush _selectedBrush;

        

        Color DefaultColor
        {
            get { return Color.White; }
        }

        public Form1()
        {
            InitializeComponent();
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
            Brush.GetSize(pictureBox1.Width, pictureBox1.Height);
            if (_selectedBrush == null)
            {
                _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
            }
            
            CreateBlank(pictureBox1.Width, pictureBox1.Height);
        }

        void CreateBlank(int width, int height)
        {
            try
            {
                var oldImage = pictureBox1.Image;
                var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                ImW = bmp.Width;
                ImH = bmp.Height;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        bmp.SetPixel(i, j, DefaultColor);
                    }
                }

                pictureBox1.Image = bmp;
                if (oldImage != null) { oldImage.Dispose(); }
            }

            catch (Exception)
            {

            }

        }
        
        private void kvadr_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if(_selectedBrush == null)
            {

                return;

            }
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            _selectedBrush.Draw((Bitmap)pictureBox1.Image, x: _x, y: _y);
            pictureBox1.Refresh();
            _mouseClicked = true;


        }

        private void pictureBox1_Mouseup(object sender, MouseEventArgs e)
        {
            _mouseClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X :0;
            _y = e.Y > 0 ? e.Y :0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw( (Bitmap)pictureBox1.Image, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void ôàéëToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void krug_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Circle(SelectedColor, SelectedSize);
        }

        private void î÷èñòèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CreateBlank(ImW, ImH) ;
                
            

        }

        private void lastic_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Eraser(SelectedColor, SelectedSize);
        }

        private void Other_Click(object sender, EventArgs e)
        {
            _selectedBrush = new Spray(SelectedColor, SelectedSize);
        }

        private void îÏðîãðàììåToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }


        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG|*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush.cColor = ((Button)sender).BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                _selectedBrush.cColor = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _selectedBrush.Size = trackBar1.Value;
        }

        private void toolsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ñïðàâêàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
        "Âåðñèÿ óïðîù¸ííîãî Paint:\nv.1.0.0",
        "Ñïðàâêà",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1);
        }

        private void line_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SlashR(SelectedColor, SelectedSize);
        }

        private void octoflower_Click(object sender, EventArgs e)
        {
           
            _selectedBrush = new octoFlower(SelectedColor, SelectedSize);


        }
    }
}