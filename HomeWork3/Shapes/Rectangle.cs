using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : Shape
    {
        private double Width { get;}
        private double Height { get;}

        public Rectangle(double width, double height)
        {
            if (width <= 0 || height <= 0) throw new Exception("输入的边长小等于0");
            this.Width = width;
            this.Height = height;
        }

        public override double Area
        {
            get => Width * Height;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Rectangle: width = {Width} height = {Height}");
        }
    }
}
