using System.ComponentModel;

namespace day_5_oop_problem_3_The_time
{
    internal partial class Program
    {
        class Time
        {

            public int Hour { get; set; }
            public int minute { get; set; }
            public int second { get; set; }
            public void addTime(int hour, int minute, int second)
            {
                Hour += hour;
            }
            public Time(int hour, int minute, int second)
            {
                Hour = hour;
                this.minute = minute;
                this.second = second;
            }

            public void showTime()
            {
                Console.WriteLine($"{Hour}:: {minute}:: {second}");
            }

            public void resteTime()
            {
                Hour = minute = second = 0;
            }

            public void adding30Minutes()
            {
                if (minute < 30) {
                    minute += 30;
                } else if (minute > 30) {
                    int temp = minute + 30;
                    if (temp > 60) {
                        Hour++;
                        minute = temp - 60;
                    }

                }


            }
            public void ConverToSecond()
            {
                int totaltsec = (Hour * 60 * 60) + second + (minute * 60);

                Console.WriteLine($"the total sec is : {totaltsec}");

            }
        }
    } 
}
