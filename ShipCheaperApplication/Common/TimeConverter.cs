using System;

namespace Common
{
    public class TimeConverter
    {
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; } = 0;

        public TimeSpan MinuteToTimeConverter(int minute)
        {
            Hour = minute / 60;
            Minute = minute - Hour * 60;
            return new TimeSpan(Hour, Minute,Second);
        }

        public TimeSpan SecondToTimeConverter(int second)
        {
            throw new NotImplementedException(); ;
        }
    }
}
