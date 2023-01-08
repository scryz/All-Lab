using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3
{
    abstract class Brush
    {
        public Color BrushColor { get; set; }
        public int Size { get; set; }
        public Brush(Color brushColor, int size)
        {
            BrushColor = brushColor;
            Size = size;
        }
        public abstract void Draw(Bitmap image, int x, int y);
    }
    class QuadBrush : Brush
    {
        public QuadBrush(Color brushColor, int size) : base(brushColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    if (x0 > 0 & y0 > 0)
                    {
                        image.SetPixel(x0, y0, BrushColor);
                    }
                }
            }
        }
    }
    class Circle : Brush
    {
        public Circle(Color brushColor, int size) : base(brushColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = -Size; y0 <= Size; y0++)
            {
                int x0 = Convert.ToInt32(Math.Sqrt(Math.Pow(Size, 2) - Math.Pow(y0, 2)));
                
                    image.SetPixel(x0 + x, y0 + y, BrushColor);
                    image.SetPixel(-x0 + x, y0 + y, BrushColor);
                
            }
            for (int x0 = -Size; x0 <= Size; x0++)
            {
                int y0 = Convert.ToInt32(Math.Sqrt(Math.Pow(Size, 2) - Math.Pow(x0, 2)));
                
                    image.SetPixel(x0 + x, y0 + y, BrushColor);
                    
                        image.SetPixel(x0 + x, -y0 + y, BrushColor);
                    
                
            }
        }

    }
    class Krug : Brush
    {
        public Krug(Color brushColor, int size) : base(brushColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = -Size; y0 <= Size; y0++)
            {
                for (int x0 = -Size; x0 <= Size; x0++)
                {
                    if ((x0 * x0) + (y0 * y0) <= (Size * Size))
                    {   
                            image.SetPixel(x0 + x, y0 + y, BrushColor);
                    }

                }
            }
        }
    }
    class Eraser : Brush
    {
        public Eraser(Color brushColor, int size) : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {

            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    if (x0 > 0 & y0 > 0)
                    {
                        image.SetPixel(x0, y0, Color.White);
                    }
                }
            }
        }
    }

    class Spray : Brush
    {
        public Spray(Color brushColor, int size) : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            Random rnd = new Random();
            for (int y0 = y - Size; y0 < y + Size; ++y0)
            {
                for (int x0 = x - Size; x0 < x + Size; ++x0)
                {
                    int randomNumber2 = rnd.Next(1, 20);
                    if (randomNumber2 == 5)
                    {
                        if (x0 > 0 & y0 > 0)
                        {
                            image.SetPixel(x0, y0, BrushColor);
                        }



                    }



                }

            }
        }
    }
 

    class SlashL : Brush
    {
        public SlashL(Color brushColor, int size) : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = -Size; y0 < Size; y0++)
            {
                for (int x0 = -Size; x0 < Size; x0++)
                {
                    if (y0 == x0)
                    {
                        if (x0 > 0 & y0 > 0)
                        {
                            image.SetPixel(-x0 + x, y0 + y, BrushColor);
                        }
                    }
                }
            }
        }
    }
    class SlashR : Brush
    {
        public SlashR(Color brushColor, int size) : base(brushColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = -Size; y0 < Size; y0++)
            {
                for (int x0 = -Size; x0 < Size; x0++)
                {
                    if (y0 == x0)
                    {
                        if (x0 > 0 & y0 > 0)
                        {
                            image.SetPixel(x0 + x, y0 + y, BrushColor);
                        }
                    }
                }
            }
        }
    }






    class Flower : Brush
    {

        public Flower(Color BrushColor, int size) : base(BrushColor, size)
        {

        }

        public override void Draw(Bitmap image, int x, int y)
        {
            int a = 2 * Size;
            double R = 0;
            double alpha = 0;
            double beta = 0;
            int x0 = x;
            int y0 = y;
            double t = 0.05;
            int x1 = 0;
            int y1 = 0;



            for (double n = 0; n < 2 * Math.PI; n += t)
            {

                R = a * Math.Sin(5 * n);
                alpha = y + Math.Sin(n) * R;
                beta = x + Math.Cos(n) * R;
                y0 = (int)alpha;
                x0 = (int)beta;

                if (x0 > 0 & y0 > 0 & x0 < Size & y0 < Size)
                {
                    image.SetPixel(x0, y0, BrushColor);
                }
                if (n > 0)
                {
                    Line.DrawLine(image as Bitmap, x1, y1, x0, y0, BrushColor);
                }
                if (x0 != x1 || y0 != y1)
                {
                    x1 = x0;
                    y1 = y0;
                }
            }
        }
    }


}