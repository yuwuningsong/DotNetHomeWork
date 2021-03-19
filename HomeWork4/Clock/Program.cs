using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Clock clock = new Clock();
                Console.WriteLine("请设置钟初始时间：");
                Console.WriteLine("Hour: ");
                int hour = int.Parse(Console.ReadLine());
                Console.WriteLine("Minute: ");
                int minute = int.Parse(Console.ReadLine());
                Console.WriteLine("Second: ");
                int second = int.Parse(Console.ReadLine());

                clock.SetTime(hour, minute, second);

                Console.WriteLine("请设置闹钟时间：");
                Console.WriteLine("Hour: ");
                hour = int.Parse(Console.ReadLine());
                Console.WriteLine("Minute: ");
                minute = int.Parse(Console.ReadLine());
                Console.WriteLine("Second: ");
                second = int.Parse(Console.ReadLine());

                clock.SetAlarm(hour, minute, second);
                clock.Tick += MyTick;
                clock.Alarm += MyAlarm;

                clock.OpenClock();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }

        static void MyTick()
        {
            Console.WriteLine("Tick! Tick!");
        }

        static void MyAlarm()
        {
            Console.WriteLine("BOOGU! BOOGU!");
        }
    }
}
