using System.Drawing;

namespace TestBusinessLayer
{
    public class CompareBitmap
    {
        public bool Compare(Bitmap bmp1, Bitmap bmp2)
        {
            if (bmp1 == null || bmp2 == null)
                return false;
            if (object.Equals(bmp1, bmp2))
                return true;
            if (!bmp1.Size.Equals(bmp2.Size) || !bmp1.PixelFormat.Equals(bmp2.PixelFormat))
                return false;

            //Compare bitmaps using GetPixel method
            for (int column = 0; column < bmp1.Width; column++)
            {
                for (int row = 0; row < bmp1.Height; row++)
                {
                    if (!bmp1.GetPixel(column, row).Equals(bmp2.GetPixel(column, row)))
                        return false;
                }
            }

            return true;
        }
    }
}
