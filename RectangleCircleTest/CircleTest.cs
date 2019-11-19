using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleCircle;
using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleCircleTest
{
    [TestClass]
    public class CircleTest
    {
        Circle circle;
        [TestInitialize]
        public void setup()
        {
            circle = new Circle("Sample Circle", 4);
        }

        [TestMethod]
        public void constructorTest()
        {
            Assert.AreEqual("Sample Circle", circle.GetName());
        }

        [TestMethod]
        public void areaTest()
        {
            Assert.AreEqual(Math.PI * 4 * 4, circle.GetArea());
        }

        [TestMethod]
        public void circumferenceTest()
        {
            Assert.AreEqual(Math.PI * 4 * 2, circle.GetCircumference());
        }
    }
}
