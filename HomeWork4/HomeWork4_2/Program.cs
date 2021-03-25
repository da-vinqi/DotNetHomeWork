using System;

namespace HomeWork4_2
{
    class Clock
    {
        public delegate void TickHandler(object sender, TickEventArgs args);
        public delegate void AlarmHandler(object sender, AlarmEventArgs args);

        public int hour { get; set; }
        public int minute { get; set; }
        public int second { get; set; }

        public Clock(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }

        public Clock() { }


        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;

        public void Tick()
        {
            Console.WriteLine("滴答滴答");
            if (this.second < 60)
            {
                this.second += 1;
            }
            else if (this.minute < 59)
            {
                this.second = 0;
                this.minute += 1;
            }
            else if(this.hour < 24)
            {
                this.minute = 0;
                this.second = 0;
                this.hour += 1;
            }
            else
            {
                this.minute = 0;
                this.second = 0;
                this.hour = 0;
            }
            TickEventArgs tickEventArgs = new TickEventArgs()
            {
                hourTickEventArgs = this.hour,
                minuteTickEventArgs = this.minute,
                secondTickEventArgs = this.second
            };
            if(this.minute ==0 && this.minute == 0) { OnTick(this, tickEventArgs); }
        }

        public void Alarm(int hour_set,int minute_set,int second_set)
        {
            if (this.hour == hour_set && this.minute == minute_set && this.second == second_set)
            {
                Console.WriteLine("闹钟响了");

                AlarmEventArgs alarmEventArgs = new AlarmEventArgs()
                {
                    hourAlarmEventArgs = this.hour,
                    minuteAlarmEventArgs = this.minute,
                    secondAlarmEventArgs = this.second
                };
                OnAlarm(this, alarmEventArgs);
            }
        }

    }

    class TickEventArgs
    {
        public int hourTickEventArgs { get; set; }
        public int minuteTickEventArgs { get; set; }
        public int secondTickEventArgs { get; set; }
    }

    class AlarmEventArgs
    {
        public int hourAlarmEventArgs { get; set; }
        public int minuteAlarmEventArgs { get; set; }
        public int secondAlarmEventArgs { get; set; }
    }

    class Demo
    {
       public Clock clock = new Clock(DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second);
        public Demo()
        {
            clock.OnTick += AtHour;
            clock.OnAlarm += WhenAlarm;
        }
        public void AtHour(object sender, TickEventArgs args)
        {
            Console.WriteLine("现在是整点报时");
            Console.WriteLine(" "+clock.hour+ " "+clock.minute+ " "+clock.second);
        }
        public void WhenAlarm(object sender, AlarmEventArgs args)
        {
            Console.WriteLine("叮铃铃");
            Console.WriteLine(" " + clock.hour + " " + clock.minute + " " + clock.second);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer t = new System.Timers.Timer(100);
            t.Elapsed += new System.Timers.ElapsedEventHandler(OnTimedEvent);
            t.AutoReset = true;
            t.Enabled = true;
            Console.Read();
        }

        public static Demo demo = new Demo();
        public static void OnTimedEvent(object source, System.Timers.ElapsedEventArgs e)
        {
            demo.clock.Tick();

            demo.clock.Alarm(13,12,0);

        }
    }
}
