namespace day_5_oop_problem_4_Enum
{
    internal class Program
    {
        [Flags]
        enum Season
        {
            spring ,
            summer ,
            Autumn ,
            winter ,


        }
        static void Main(string[] args)
        {
            string seasonName = Console.ReadLine().ToLower();

            if (seasonName == Season.spring.ToString()) {
                Console.WriteLine("feb , march , April , may ");
            }else if (seasonName == Season.spring.ToString())
            {
                Console.WriteLine("june , july , septemer , 8 ");

            }
            else if (seasonName == Season.spring.ToString())
            {
                Console.WriteLine(" 9 , 10 , 11 , 12");

            }
            else
            {
                Console.WriteLine("feb , march , April , ");

            }


        }
    }
}
