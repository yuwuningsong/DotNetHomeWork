using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num = 10;
                Console.WriteLine($"随机创建{num}个形状对象:");
                ShapeFactory sf = new ShapeFactory();
                Shape[] shapes = sf.GetShapes(num);
                double areaSum = 0;

                // 输出num个形状信息并计算面积
                for (int i = 0; i < num; i++)
                {
                    shapes[i].ShowInfo();
                    areaSum += shapes[i].Area;
                }

                Console.WriteLine($"面积总和为{areaSum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
