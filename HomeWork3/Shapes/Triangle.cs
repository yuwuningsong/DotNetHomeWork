using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        private double SideOne { get;}
        private double SideTwo { get;}
        private double SideThree { get;}

        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            if (sideOne <= 0 || sideTwo <= 0 || sideThree <= 0) throw new Exception("输入的边长小等于0");  
            this.SideOne = sideOne;
            this.SideTwo = sideTwo;
            this.SideThree = sideThree;
        }

        // 判断是否能形成三角形
        public bool IsTriangle()
        {
            if (this == null) return false;
            if (SideOne + SideTwo <= SideThree || SideTwo + SideThree <= SideOne || SideOne + SideThree <= SideTwo)
            {
                return false;
            }
            return true;
        }

        public override double Area
        {
            get
            { 
                double p = (SideOne + SideTwo + SideThree) / 2;
                return Math.Sqrt(p * (p - SideOne) * (p - SideTwo) * (p - SideThree));
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Triangle: sideOne = {SideOne} sideTwo = {SideTwo} sideThree = {SideThree}");
        }
    }
}
