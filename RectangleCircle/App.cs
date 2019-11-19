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
            writeline(rectangle.ToString());


            var circle = new Circle("Sample Circle",4);
            writeline(circle.ToString());


        }
    }
}
