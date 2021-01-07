using System.Drawing;
using System.Drawing.Drawing2D;
using Input_Output_Files;

namespace Business_Layer
{
    public class ImportExportImage : IImportExportImage
    {

        public void SaveImg(Bitmap bitmap)
        {
            InOutPutFile.SaveImage(bitmap);
        }

        public Bitmap LoadImg()
        {
            return CopyToSquareCanvas(InOutPutFile.LoadImage(), 600);
        }


        //Method use in the load Image
        public Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght)
        {
            if (sourceBitmap != null)
            {
                float ratio = 1.0f;
                int maxSide = sourceBitmap.Width > sourceBitmap.Height ?
                              sourceBitmap.Width : sourceBitmap.Height;

                ratio = (float)maxSide / (float)canvasWidthLenght;

                Bitmap bitmapResult = (sourceBitmap.Width > sourceBitmap.Height ?
                                        new Bitmap(canvasWidthLenght, (int)(sourceBitmap.Height / ratio))
                                        : new Bitmap((int)(sourceBitmap.Width / ratio), canvasWidthLenght));

                using (Graphics graphicsResult = Graphics.FromImage(bitmapResult))
                {
                    graphicsResult.CompositingQuality = CompositingQuality.HighQuality;
                    graphicsResult.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphicsResult.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    graphicsResult.DrawImage(sourceBitmap,
                                            new Rectangle(0, 0,
                                                bitmapResult.Width, bitmapResult.Height),
                                            new Rectangle(0, 0,
                                                sourceBitmap.Width, sourceBitmap.Height),
                                                GraphicsUnit.Pixel);
                    graphicsResult.Flush();
                }

                return bitmapResult;
            } else
            {
                return null;
            }
        }
    }
}
