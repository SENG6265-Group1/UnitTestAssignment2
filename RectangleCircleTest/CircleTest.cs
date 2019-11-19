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
        #region positive Tests
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

        [TestMethod]
        public void outputTest()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Sample Circle");
            sb.AppendLine("Circle Area: 50.2654824574367");
            sb.AppendLine("Circle circumference: 25.1327412287183");
            
            Assert.AreEqual(sb.ToString(), circle.ToString());
        }

        #endregion

        #region negative tests

        [TestMethod]
        public void perimeterFailureTest()
        {
            Assert.AreNotEqual(4 * 2 * 3.14, circle.GetCircumference());
        }

        [TestMethod]
        public void areaFailureTest()
        {
            Assert.AreNotEqual(4 * 4 * 3.14, circle.GetArea());
        }
        #endregion
    }
}
