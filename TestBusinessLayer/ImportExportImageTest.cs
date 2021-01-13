using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Business_Layer;
using Input_Output_Files;
using System.Drawing.Imaging;
using NSubstitute;

namespace TestBusinessLayer
{
    [TestClass]
    public class ImportExportImageTest
    {
        private readonly IImportExportImage ieImage;
        private readonly CompareBitmap compareBitmap = new CompareBitmap();
        private readonly IInOutPutFile ioFile;

        public ImportExportImageTest()
        {
            ieImage = new ImportExportImage(ieImage, ioFile);
        }

        [TestMethod]
        public void TestSaveImage()
        {
            var ioFileSubstitute = Substitute.For<IInOutPutFile>();

            IImportExportImage ieImageTest = new ImportExportImage(ieImage, ioFileSubstitute);

            Bitmap bitmap = null;

            ieImageTest.SaveImg(bitmap);

            Assert.IsTrue(true);
        }




        [TestMethod]
        public void LoadImg()
        {
            var ioFileSubstitute = Substitute.For<IInOutPutFile>();

            ioFileSubstitute.LoadImage().Returns<Bitmap>(new Bitmap("..\\Sources\\test.png"));

            IImportExportImage ieImageTest = new ImportExportImage(ieImage, ioFileSubstitute);

            Bitmap btmp = (Bitmap)ieImageTest.LoadImg();

            Assert.IsTrue(compareBitmap.Compare(btmp, new Bitmap("..\\Sources\\test.png")));
        }





        [TestMethod]
        public void TestCopyToSquareCanvasNullImage()
        {
            Bitmap btmp = ieImage.CopyToSquareCanvas(null, 600);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestCopyToSquareCanvasNegativeCanevasLength()
        {
            Bitmap btmp = ieImage.CopyToSquareCanvas(new Bitmap("..\\Sources\\test.png"), -2);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestCopyToSquareCanvasNoNeedToResize()
        {
            Bitmap btmp = ieImage.CopyToSquareCanvas(new Bitmap("..\\Sources\\test.png"), 600);
            Bitmap resultBitmap = new Bitmap("..\\Sources\\test.png");
            Assert.IsTrue(compareBitmap.Compare(btmp, resultBitmap));
        }

        [TestMethod]
        public void TestCopyToSquareCanvasLarger()
        {
            Bitmap btmp = ieImage.CopyToSquareCanvas(new Bitmap("..\\Sources\\logo.png"), 600);
            Bitmap resultBitmap = new Bitmap("..\\Sources\\logoAfter.png");
            Assert.IsTrue(compareBitmap.Compare(btmp, resultBitmap));
        }
    }
}
