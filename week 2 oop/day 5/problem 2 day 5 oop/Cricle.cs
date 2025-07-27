using System.Formats.Asn1;

namespace problem_2_day_5_oop
{
    internal partial class Program
    {
        class Cricle
        {
            public double radius { get; set; }
            private double pi = 3.14;

            public Cricle(double radius)
            {
                this.radius = radius;
            }

            public void printArea()
            {
                Console.WriteLine($"{radius * 1/2 * pi} the area ");
            }

            public void perimeter()
            {
                Console.WriteLine($"{radius * 1 / 2 * pi} the area ");

            }



        }
    }
}
