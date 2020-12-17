using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
   interface IEdgeFilters
    {
        Bitmap Laplacian3x3Filter(Bitmap sourceBitmap, bool grayscale);

        Bitmap Laplacian5x5Filter(Bitmap sourceBitmap, bool grayscale);

        Bitmap LaplacianOfGaussianFilter(Bitmap sourceBitmap);

        Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix,
                                 double factor = 1, int bias = 0, bool grayscale = false);

        Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght);


    }
}
