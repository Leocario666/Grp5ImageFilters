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
        private readonly ImageFilters imageFilters = new ImageFilters();
        private readonly CompareBitmap compareBitmap = new CompareBitmap();

        [TestMethod]
        public void TestNullBitmapInput()
        {
            Bitmap bitmap = imageFilters.ApplyFilter(null, -1, -1, -1, -1);
            Assert.AreEqual(bitmap, null);
        }

        [TestMethod]
        public void TestBelowARGBValue()
        {
            Bitmap bitmap = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), -1, -1, -1, -1);
            Assert.AreEqual(bitmap, null);
        }

        [TestMethod]
        public void TestBelowAlphaValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), -1, 1, 1, 25);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestBelowRedValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, -1, 1, 25);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestBelowBlueValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, -1, 25);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestBelowGreenValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 1, -25);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestAboveARGBValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 256, 256, 256, 256);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestAboveAlphaValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 256, 1, 1, 25);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestAboveRedValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 256, 1, 25);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestAboveBlueValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 256, 25);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestAboveGreenValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 1, 256);
            Assert.AreEqual(btmp, null);
        }

        [TestMethod]
        public void TestValidARGBValue()
        {
            Bitmap btmp = imageFilters.ApplyFilter(new Bitmap("..\\Sources\\test.png"), 1, 1, 1, 25);
            Bitmap resultBitmap = new Bitmap("..\\Sources\\night.png");
            Assert.IsTrue(compareBitmap.Compare(btmp, resultBitmap));
        }
    }
}
