using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeFactory
    {
        private enum Shapes { Rectangle, Square, Triangle};
        private static int size = 3;
        private Random rd = new Random();

        // 随机批量创建形状
        public Shape[] GetShapes(int num, double sizeLimit = 20)
        {
            Shape[] shapes = new Shape[num];
            for (int i = 0; i < num; i++)
            {
                shapes[i] = GetOneShape(sizeLimit);
            }
            return shapes;
        }

        // 随机创建单个形状
        public Shape GetOneShape(double sizeLimit = 20)
        {
            Shape shape = null;
            int type = rd.Next(size);

            if (type == (int)Shapes.Rectangle)
            {
                double width = rd.NextDouble() * sizeLimit;
                double height = rd.NextDouble() * sizeLimit;
                shape = new Rectangle(width, height);
            }
            else if (type == (int)Shapes.Square)
            {
                double side = rd.NextDouble() * sizeLimit;
                shape = new Square(side);
            }
            else if (type == (int)Shapes.Triangle)
            {
                Triangle triangle;
                do
                {
                    double sideOne = rd.NextDouble() * sizeLimit;
                    double sideTwo = rd.NextDouble() * sizeLimit;
                    double sideThree = rd.NextDouble() * sizeLimit;
                    triangle = new Triangle(sideOne, sideTwo, sideThree);
                } while (!triangle.IsTriangle());
                shape = triangle;
            }

            return shape;
        }
    }
}
