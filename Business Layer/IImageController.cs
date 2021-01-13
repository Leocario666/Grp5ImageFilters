using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Business_Layer
{
    public interface IImageController
    {
        void SaveImg(Bitmap bitmap);

        Bitmap LoadImg();
    }
}
