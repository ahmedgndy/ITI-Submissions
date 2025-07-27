namespace day_5_oop_problem_3_The_time
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time(12, 60 , 10);
            time.showTime();
            time.resteTime();
            time.showTime();
            time.adding30Minutes();
            time.adding30Minutes();
            time.showTime();
        
        }
    }
}
