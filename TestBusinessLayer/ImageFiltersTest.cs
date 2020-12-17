using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Business_Layer;
using System.Drawing.Imaging;

namespace TestBusinessLayer
{
    [TestClass]
    public class ImageFiltersTest
    {
        [TestMethod]
        public void TestBelowARGBValue()
        {
            Bitmap bitmap = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), -1, -1, -1, -1);
            Bitmap resultBitmap = null;
            Assert.AreEqual(bitmap, resultBitmap);
        }

        [TestMethod]
        public void TestBelowAlphaValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), -1, 1, 1, 25);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestBelowRedValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, -1, 1, 25);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestBelowBlueValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, -1, 25);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestBelowGreenValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 1, -25);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestAboveARGBValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 256, 256, 256, 256);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestAboveAlphaValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 256, 1, 1, 25);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestAboveRedValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 256, 1, 25);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestAboveBlueValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 256, 25);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestAboveGreenValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 1, 256);
            Bitmap resultBitmap = null;
            Assert.AreEqual(btmp, resultBitmap);
        }

        [TestMethod]
        public void TestValidARGBValue()
        {
            Bitmap btmp = ImageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 1, 25);
            Bitmap resultBitmap = new Bitmap("..\\Sources\\night.png");
            Assert.IsTrue(CompareBitmap.Compare(btmp, resultBitmap));
        }
    }
}
