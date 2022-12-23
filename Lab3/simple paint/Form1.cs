using System.Drawing.Imaging;
using System.Windows.Forms;

namespace simple_paint
{
    
    public partial class Form1 : Form
    {
        
        int _x;
        int _y;
        bool _mouseClicked = false;

        int ImW, ImH;
        string MyBrush;

        Color SelectedColor
        {
            get { return Color.Black; }
        }


        int SelectedSize;
        
        Brush _selectedBrush ;

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

        private void ñîçäàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
                
            }

        }

        private void pryamo_Click(object sender, EventArgs e)
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



        private void redBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void greenBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void blueBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            {
                int width = Convert.ToInt32(pictureBox1.Width);
                int height = Convert.ToInt32(pictureBox1.Height);
                using (Bitmap bmp = new Bitmap(width, height))
                {
                    pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                    bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                }
            }
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
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



        private void octoflower_Click_1(object sender, EventArgs e)
        {
           
            _selectedBrush = new octoFlower(SelectedColor, SelectedSize);


        }
    }
}