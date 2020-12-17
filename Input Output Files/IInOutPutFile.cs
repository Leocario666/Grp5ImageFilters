using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Output_Files
{
    public interface IInOutPutFile
    {
        void SaveImage(Bitmap image);

        Bitmap LoadImage();
    }
}
