using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Time
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public bool IsValid { get; set; }           // 是否合法

        public Time(int hour, int minute, int second)
        {
            if (hour >= 24 || minute >= 60 || second >= 60 || hour < 0 || minute < 0 || second < 0)
            {
                IsValid = false;
            }
            else
            {
                IsValid = true;
            }
            this.Hour = hour;
            this.Minute = minute;
            this.Second = second;
        }

        public Time() : this(0, 0, 0) { }

        public bool Equals(Time time)
        {
            if (time.Hour != this.Hour || time.Minute != this.Minute || time.Second != this.Second) return false;
            return true;
        }

        // 按秒走时
        public void AddTime()
        {
            this.Second++;
            if (Second >= 60)
            {
                Minute++;
                Second %= 60;
            }
        }
    }
}
