using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleCircle;

namespace RectangleCircleTest
{
    [TestClass]
    public class RectangleTest
    {
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
        public void circumferenceTest()
        {
            Assert.AreEqual(12, rectangle.GetPerimeter());
        }
    }
}
