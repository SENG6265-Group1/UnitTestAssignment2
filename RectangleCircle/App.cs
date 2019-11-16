using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleCircle
{
    public class App
    {
        private Action<string> writeline;

        public App(Action<string> writeline)
        {
            this.writeline = writeline;
        }

        public void Run()
        {
            var rectangle = new Rectangle("Sample Rectangle",2,4);

            writeline(rectangle.GetName());
            writeline("Rectangle Area: " + rectangle.GetArea());
            writeline("Rectangle Permeter: " + rectangle.GetPerimeter());


            var circle = new Circle("Sample Circle",4);

            writeline(circle.GetName());
            writeline("Circle Area: " + circle.GetArea());
            writeline("Circle circumference: " + circle.GetCircumference());


        }
    }
}
