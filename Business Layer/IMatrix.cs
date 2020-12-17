using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    interface IMatrix
    {
        double[,] Laplacian3x3();

        double[,] Laplacian5x5();

        double[,] LaplacianOfGaussian();
    }
}
