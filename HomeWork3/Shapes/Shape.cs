using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        // 面积
        abstract public double Area { get; }
        // 打印信息
        abstract public void ShowInfo();
    }
}
