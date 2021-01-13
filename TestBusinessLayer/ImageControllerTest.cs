using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Layer;
using Input_Output_Files;
using System.Drawing.Imaging;
using NSubstitute;
using System.Drawing;

namespace TestBusinessLayer
{
    [TestClass]
    public class ImageControllerTest
    {
        private readonly IImageController iImageController;
        private readonly CompareBitmap compareBitmap = new CompareBitmap();

        public ImageControllerTest()
        {
            iImageController = new ImageController();
        }


        [TestMethod]
        public void TestSaveImage()
        {
            var IieImageSubstitute = Substitute.For<IImportExportImage>();

            IImageController iImageControllerTest = new ImageController(IieImageSubstitute);

            Bitmap bitmap = null;

            iImageControllerTest.SaveImg(bitmap);

            Assert.IsTrue(true);
        }

        [TestMethod]
        public void LoadImg()
        {
            var IieImageSubstitute = Substitute.For<IImportExportImage>();

            IieImageSubstitute.LoadImg().Returns<Bitmap>(new Bitmap("..\\Sources\\test.png"));

            IImageController iImageControllerTest = new ImageController(IieImageSubstitute);

            Bitmap btmp = (Bitmap)iImageControllerTest.LoadImg();

            Assert.IsTrue(compareBitmap.Compare(btmp, new Bitmap("..\\Sources\\test.png")));
        }
    }
}
