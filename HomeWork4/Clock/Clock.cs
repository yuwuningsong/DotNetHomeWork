using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public delegate void ClockHandler();

    class Clock
    {
        public event ClockHandler Tick;
        public event ClockHandler Alarm;

        private Time time;
        private Time alarmTime;

        public Time Time { get; set; }
        public Time AlarmTime { get; set; }

        // 设置时间
        public void SetTime(int hour, int minute, int second)
        {
            time = new Time(hour, minute, second);
            if (!time.IsValid) throw new Exception("时间输入超出范围！");
            IsAlarm();
        }

        // 设置闹钟
        public void SetAlarm(int hour, int minute, int second)
        {
            alarmTime = new Time(hour, minute, second);
            if (!time.IsValid) throw new Exception("时间输入超出范围！");
            Alarm += new ClockHandler(PrintTime);
        }

        // 开启钟
        public void OpenClock()
        {
            Console.WriteLine("滴！闹钟走时！");
            
            while (true)
            {
                time.AddTime();
                Tick();
                if (IsAlarm()) break;
            }
        }

        // 判断闹钟响铃
        private bool IsAlarm()
        {
            if (alarmTime != null && time.Equals(alarmTime))
            {
                Alarm();
                return true;
            }
            return false;
        }

        // 报时
        public void PrintTime()
        {
            Console.WriteLine($"现在时间：{time.Hour}时 {time.Minute}分 {time.Second}秒");
        }
    }
}
