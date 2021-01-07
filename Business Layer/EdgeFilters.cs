using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Business_Layer
{
    public class EdgeFilters : IEdgeFilters
    {
        private readonly Matrix matrix = new Matrix();
        public Bitmap ApplyEdgeDetection(Bitmap sourceBitmap, string selection)
        {
            Bitmap bitmapResult;

            switch (selection)
            {
                case "Laplacian 3x3": 
                    bitmapResult = Laplacian3x3Filter(sourceBitmap);
                    break;
                case "Laplacian 5x5": 
                    bitmapResult = Laplacian5x5Filter(sourceBitmap);
                    break;
                case "Laplacian of Gaussian": 
                    bitmapResult = LaplacianOfGaussianFilter(sourceBitmap);
                    break;
                default:
                    bitmapResult = sourceBitmap;
                    break;
            }

            return bitmapResult;

        }

        public Bitmap Laplacian3x3Filter(Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = ConvolutionFilter(sourceBitmap,
                                    matrix.Laplacian3x3);

            return resultBitmap;
        }

        public Bitmap Laplacian5x5Filter(Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = ConvolutionFilter(sourceBitmap,
                                     matrix.Laplacian5x5);

            return resultBitmap;
        }

        public Bitmap LaplacianOfGaussianFilter(Bitmap sourceBitmap)
        {
            Bitmap resultBitmap = ConvolutionFilter(sourceBitmap,
                                  matrix.LaplacianOfGaussian);

            return resultBitmap;
        }

        public Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix)
        {
            {
                BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                                         sourceBitmap.Width, sourceBitmap.Height),
                                                           ImageLockMode.ReadOnly,
                                                     PixelFormat.Format32bppArgb);

                byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
                byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];

                Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
                sourceBitmap.UnlockBits(sourceData);

                double blue;
                double green;
                double red;

                int filterWidth = filterMatrix.GetLength(1);

                int filterOffset = (filterWidth - 1) / 2;
                int calcOffset;

                int byteOffset;

                for (int offsetY = filterOffset; offsetY <
                    sourceBitmap.Height - filterOffset; offsetY++)
                {
                    for (int offsetX = filterOffset; offsetX <
                        sourceBitmap.Width - filterOffset; offsetX++)
                    {
                        blue = 0;
                        green = 0;
                        red = 0;

                        byteOffset = offsetY *
                                     sourceData.Stride +
                                     offsetX * 4;

                        for (int filterY = -filterOffset;
                            filterY <= filterOffset; filterY++)
                        {
                            for (int filterX = -filterOffset;
                                filterX <= filterOffset; filterX++)
                            {

                                calcOffset = byteOffset +
                                             (filterX * 4) +
                                             (filterY * sourceData.Stride);

                                blue += (double)(pixelBuffer[calcOffset]) *
                                        filterMatrix[filterY + filterOffset,
                                                            filterX + filterOffset];

                                green += (double)(pixelBuffer[calcOffset + 1]) *
                                         filterMatrix[filterY + filterOffset,
                                                            filterX + filterOffset];

                                red += (double)(pixelBuffer[calcOffset + 2]) *
                                       filterMatrix[filterY + filterOffset,
                                                          filterX + filterOffset];
                            }
                        }

                        if (blue > 255)
                        { blue = 255; }
                        else if (blue < 0)
                        { blue = 0; }

                        if (green > 255)
                        { green = 255; }
                        else if (green < 0)
                        { green = 0; }

                        if (red > 255)
                        { red = 255; }
                        else if (red < 0)
                        { red = 0; }

                        resultBuffer[byteOffset] = (byte)(blue);
                        resultBuffer[byteOffset + 1] = (byte)(green);
                        resultBuffer[byteOffset + 2] = (byte)(red);
                        resultBuffer[byteOffset + 3] = 255;
                    }
                }

                Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);

                BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                         resultBitmap.Width, resultBitmap.Height),
                                                          ImageLockMode.WriteOnly,
                                                     PixelFormat.Format32bppArgb);

                Marshal.Copy(resultBuffer, 0, resultData.Scan0, resultBuffer.Length);
                resultBitmap.UnlockBits(resultData);

                return resultBitmap;
            }
        }
    }
}
