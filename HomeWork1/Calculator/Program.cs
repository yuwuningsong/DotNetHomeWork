using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("请输入两个数字:");
                double numOne = double.Parse(Console.ReadLine());
                double numTwo = double.Parse(Console.ReadLine());
                Console.WriteLine("请输入一个运算符：");
                char c = (char)Console.Read();

                double result;
                switch (c)
                {
                    case '+': result = numOne + numTwo; break;
                    case '-': result = numOne - numTwo; break;
                    case '*': result = numOne * numTwo; break;
                    case '/': result = numOne / numTwo; break;
                    default: Console.WriteLine("输入不合法！"); return;
                }

                Console.WriteLine($"结果是：{result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
            
        }
    }
}
