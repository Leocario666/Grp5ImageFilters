using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Input_Output_Files;

namespace Business_Layer
{
    public class ImportExportImage : IImportExportImage
    {
        InOutPutFile ioFile = new InOutPutFile();

        public void SaveImg(Bitmap bitmap)
        {
            ioFile.SaveImage(bitmap);
        }

        public Bitmap LoadImg()
        {
            return CopyToSquareCanvas(ioFile.LoadImage(), 600);
        }


        //Method use in the load Image
        public Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght)
        {
            try 
            {
                float ratio;
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
            } catch(Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}
