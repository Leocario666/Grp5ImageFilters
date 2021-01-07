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
        Bitmap ApplyEdgeDetection(Bitmap sourceBitmap, string selection);

        Bitmap Laplacian3x3Filter(Bitmap sourceBitmap);

        Bitmap Laplacian5x5Filter(Bitmap sourceBitmap);

        Bitmap LaplacianOfGaussianFilter(Bitmap sourceBitmap);

        Bitmap ConvolutionFilter(Bitmap sourceBitmap, double[,] filterMatrix);



    }
}
