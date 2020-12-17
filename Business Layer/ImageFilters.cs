using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Business_Layer
{
    public static class ImageFilters
    {

        //apply color filter with primary color numbers
        public static Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green)
        {
            if (Enumerable.Range(0, 255).Contains(alpha) && Enumerable.Range(0, 255).Contains(red) && Enumerable.Range(0, 255).Contains(blue) && Enumerable.Range(0, 255).Contains(green))
            {

                Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

                for (int i = 0; i < bmp.Width; i++)
                {
                    for (int x = 0; x < bmp.Height; x++)
                    {
                        Color c = bmp.GetPixel(i, x);
                        Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                        temp.SetPixel(i, x, cLayer);
                    }
                }
                return temp;
            }
            return null;
        }

    }
}
