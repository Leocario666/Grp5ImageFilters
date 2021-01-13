using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Input_Output_Files;

namespace Business_Layer
{
    public class ImageController : IImageController
    {
        public IImportExportImage iimportExportImage;
        private readonly IInOutPutFile ioFile;

        public ImageController()
        {
            this.ioFile = new InOutPutFile(ioFile);
            this.iimportExportImage = new ImportExportImage(iimportExportImage, ioFile);
        }

        public ImageController(IImportExportImage ieImage)
        {
            this.ioFile = new InOutPutFile(ioFile);
            this.iimportExportImage = ieImage;
        }

        public void SaveImg(Bitmap bitmap)
        {
            iimportExportImage.SaveImg(bitmap);
        }

        public Bitmap LoadImg()
        {
            return iimportExportImage.LoadImg();
        }
    }
}
