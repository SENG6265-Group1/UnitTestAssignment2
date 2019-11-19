using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace RectangleCircle
{
    public class Circle
    {
        private string name;
        private float radius; 

        public Circle(string name, float radius)
        {
            this.name = name;
            this.radius = radius;
        }

        public string GetName()
        {
            return name;
        }

        public float GetRadius()
        {
            return radius;
        }

        public double GetArea()
        {
            return PI * radius * radius; 
        }

        public double GetCircumference()
        {

            return radius * 2 * PI ;
        }
    }
}
