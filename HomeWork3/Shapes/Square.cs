using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Square : Rectangle
    {
        private double Side { get; }

        public Square(double side) : base(side, side)
        {
            this.Side = side;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Square: side = {Side}");
        }
    }
}
