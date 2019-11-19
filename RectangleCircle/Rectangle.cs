using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleCircle
{
    public class Rectangle
    {
        private string name;
        private float length;
        private float width;

        public Rectangle(string name, float length, float width)
        {
            this.name = name;
            this.length = length;
            this.width = width;
        }

        public string GetName()
        {
            return name;
        }

        public float GetLength()
        {
            return length;
        }

        public float GetWidth()
        {
            return width;
        }
        
        public float GetArea()
        {
            return (length * width);
        }

        public float GetPerimeter()
        {
           
            return 2 * (length + width);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(GetName());
            sb.AppendLine("Rectangle Area: " + GetArea());
            sb.AppendLine("Rectangle Permeter: " + GetPerimeter()); 
            return sb.ToString();
        }
    }
}
