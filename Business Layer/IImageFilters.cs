using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Business_Layer
{
    interface IImageFilters
    {
        Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green);
    }
}
