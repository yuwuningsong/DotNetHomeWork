using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 整型链表
            GenericList<int> intList = new GenericList<int>();
            for (int i = 1; i <= 10; i++)
            {
                intList.Add(i);
            }

            // 打印整型链表
            intList.MyForEach(x => Console.WriteLine(x));
            
            // 求最大值
            int max = int.MinValue;
            intList.MyForEach(x => max = x > max ? x : max);
            Console.WriteLine($"MAX: {max}");

            // 求最小值
            int min = int.MaxValue;
            intList.MyForEach(x => min = x < min ? x : min);
            Console.WriteLine($"MIN: {min}");

            // 求和
            int sum = 0;
            intList.MyForEach(x => sum += x);
            Console.WriteLine($"SUM: {sum}");
        }
    }
}
