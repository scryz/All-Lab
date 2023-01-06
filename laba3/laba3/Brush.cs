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
        public Color cColor { get; set; }
        public int Size { get; set; }
        public Brush(Color cColor, int size)
        {
            this.cColor = cColor;
            Size = size;
        }
        public abstract void Draw(Bitmap image, int x, int y);
    }
    class QuadBrush : Brush
    {
        public QuadBrush(Color cColor, int size) : base(cColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    image.SetPixel(x0, y0, cColor);
                }
            }
        }
    }

    class Circle : Brush
    {
        public Circle(Color cColor, int size) : base(cColor, size)
        {
        }

        public override void Draw(Bitmap image, int x, int y)
        {
            for (int y0 = -Size; y0 <= Size; y0++)
            {
                int x0 = Convert.ToInt32(Math.Sqrt(Math.Pow(Size, 2) - Math.Pow(y0, 2)));
                image.SetPixel(x0 + x, y0 + y, cColor);
                image.SetPixel(-x0 + x, y0 + y, cColor);
            }
            for (int x0 = -Size; x0 <= Size; x0++)
            {
                int y0 = Convert.ToInt32(Math.Sqrt(Math.Pow(Size, 2) - Math.Pow(x0, 2)));
                image.SetPixel(x0 + x, y0 + y, cColor);
                image.SetPixel(x0 + x, -y0 + y, cColor);
            }
        }
    }

    class Eraser : Brush
    {
        public Eraser(Color cColor, int size) : base(cColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {

            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    image.SetPixel(x0, y0, Color.White);
                }
            }
        }
    }

    class Spray : Brush
    {
        public Spray(Color cColor, int size) : base(cColor, size)
        {
        }
        public override void Draw(Bitmap image, int x, int y)
        {
            Random random = new Random();
            for (int y0 = y - Size; y0 < y + Size; y0++)
            {
                for (int x0 = x - Size; x0 < x + Size; x0++)
                {
                    int randompx = random.Next(-Size, Size);
                    int randompy = random.Next(-Size, Size);
                    if (((x - x0) * (x - x0)) + ((y - y0) * (y - y0)) < (Size * Size))
                    {
                        image.SetPixel(x0 + randompx, y0 + randompy, cColor);
                    }

                }
            }
        }
    }

}