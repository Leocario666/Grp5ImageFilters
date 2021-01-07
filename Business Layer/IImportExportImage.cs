using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Business_Layer
{
    interface IImportExportImage
    {
        void SaveImg(Bitmap bitmap);

        Bitmap LoadImg();

        Bitmap CopyToSquareCanvas(Bitmap sourceBitmap, int canvasWidthLenght);

    }
}
