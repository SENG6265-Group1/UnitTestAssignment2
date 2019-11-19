using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleCircle;
using System.Text;

namespace RectangleCircleTest
{
    [TestClass]
    public class RectangleTest
    {
        #region positive Tests
        Rectangle rectangle;
        [TestInitialize]
        public void setup()
        {
            rectangle = new Rectangle("Sample Rectangle", 2, 4);
        }

        [TestMethod]
        public void constructorTest()
        {
            Assert.AreEqual("Sample Rectangle", rectangle.GetName());
        }

        [TestMethod]
        public void areaTest()
        {
            Assert.AreEqual(8, rectangle.GetArea());
        }

        [TestMethod]
        public void perimeter()
        {
            Assert.AreEqual(12, rectangle.GetPerimeter());
        }

        [TestMethod]
        public void outputTest()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Sample Rectangle");
            sb.AppendLine("Rectangle Area: 8");
            sb.AppendLine("Rectangle Permeter: 12");

            Assert.AreEqual(sb.ToString(), rectangle.ToString());
        }

        #endregion

        #region negative tests

        [TestMethod]
        public void perimeterFailureTest()
        {
            Assert.AreNotEqual(12.000000000001, rectangle.GetPerimeter());
        }

        [TestMethod]
        public void areaFailureTest()
        {
            Assert.AreNotEqual(8.00000000000001, rectangle.GetArea());
        }

        #endregion
    }
}
