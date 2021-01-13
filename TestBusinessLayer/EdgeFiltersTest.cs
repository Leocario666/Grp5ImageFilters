using Business_Layer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBusinessLayer
{
    [TestClass]
    public class EdgeFiltersTest
    {
        private IEdgeFilters edgeFilters;
        private readonly CompareBitmap compareBitmap = new CompareBitmap();

        public EdgeFiltersTest()
        {
            edgeFilters = new EdgeFilters(edgeFilters);
        }

        [TestMethod]
        public void TestApplyEdgeDetectionSelectionNull()
        {
            Bitmap bitmap = edgeFilters.ApplyEdgeDetection(new Bitmap("..\\Sources\\test.png"), null);
            Assert.IsTrue(compareBitmap.Compare(bitmap, new Bitmap("..\\Sources\\test.png")));
        }

        [TestMethod]
        public void TestApplyEdgeDetectionImageNull()
        {
            Bitmap bitmap = edgeFilters.ApplyEdgeDetection(null, "Laplacian 3x3");
            Assert.AreEqual(bitmap, null);
        }

        [TestMethod]
        public void TestApplyEdgeDetectionLaplacian3x3()
        {
            Bitmap bitmap = edgeFilters.ApplyEdgeDetection(new Bitmap("..\\Sources\\test.png"), "Laplacian 3x3");
            Bitmap resultBitmap = new Bitmap("..\\Sources\\laplacian3x3.png");
            Assert.IsTrue(compareBitmap.Compare(bitmap, resultBitmap));
        }

        [TestMethod]
        public void TestApplyEdgeDetectionLaplacian5x5()
        {
            Bitmap bitmap = edgeFilters.ApplyEdgeDetection(new Bitmap("..\\Sources\\test.png"), "Laplacian 5x5");
            Bitmap resultBitmap = new Bitmap("..\\Sources\\laplacian5x5.png");
            Assert.IsTrue(compareBitmap.Compare(bitmap, resultBitmap));
        }


        [TestMethod]
        public void TestApplyEdgeDetectionLaplacianOfGaussian()
        {
            Bitmap bitmap = edgeFilters.ApplyEdgeDetection(new Bitmap("..\\Sources\\test.png"), "Laplacian of Gaussian");
            Bitmap resultBitmap = new Bitmap("..\\Sources\\laplacianofgaussian.png");
            Assert.IsTrue(compareBitmap.Compare(bitmap, resultBitmap));
        }


        
        [TestMethod]
        public void TestLaplacian3x3FilterNull()
        {
            Bitmap bitmap = edgeFilters.Laplacian3x3Filter(null);
            Assert.AreEqual(bitmap, null);
        }

        [TestMethod]
        public void TestLaplacian5x5FilterNull()
        {
            Bitmap bitmap = edgeFilters.Laplacian5x5Filter(null);
            Assert.AreEqual(bitmap, null);
        }

        [TestMethod]
        public void TestLaplacianofgaussianFilterNull()
        {
            Bitmap bitmap = edgeFilters.LaplacianOfGaussianFilter(null);
            Assert.AreEqual(bitmap, null);
        }

        [TestMethod]
        public void TestConvolutionFilterNull()
        {
            Bitmap bitmap = edgeFilters.ConvolutionFilter(null, null);
            Assert.AreEqual(bitmap, null);
        }



    }
}
