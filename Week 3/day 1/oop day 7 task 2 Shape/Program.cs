namespace oop_day_7_task_2_Shape
{

    public abstract class Shape
    {
        public abstract void Draw();
    }


    public abstract class Shape2D : Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape2D
    {
        public double Radius { get; set; }

        public override void Draw() => Console.WriteLine("Drawing a Circle");
        public override double GetArea() => Math.PI * Radius * Radius;
    }

    public class Square : Shape2D
    {
        public double Side { get; set; }

        public override void Draw() => Console.WriteLine("Drawing a Square");
        public override double GetArea() => Side * Side;
    }

    public class Triangle : Shape2D
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public override void Draw() => Console.WriteLine("Drawing a Triangle");
        public override double GetArea() => 0.5 * Base * Height;
    }

    public abstract class Shape3D : Shape
    {
        public abstract double GetVolume();
    }

    public class Sphere : Shape3D
    {
        public double Radius { get; set; }

        public override void Draw() => Console.WriteLine("Drawing a Sphere");
        public override double GetVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
    }

    public class Cube : Shape3D
    {
        public double Side { get; set; }

        public override void Draw() => Console.WriteLine("Drawing a Cube");
        public override double GetVolume() => Math.Pow(Side, 3);
    }

    public class Tetrahedron : Shape3D
    {
        public double Side { get; set; }

        public override void Draw() => Console.WriteLine("Drawing a Tetrahedron");
        public override double GetVolume() => (Math.Pow(Side, 3)) / (6 * Math.Sqrt(2));
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape2D circle = new Circle { Radius = 5 };
            circle.Draw();
            Console.WriteLine($"Area: {circle.GetArea()}");
            Shape3D cube = new Cube { Side = 3 };
            cube.Draw();
            Console.WriteLine($"Volume: {cube.GetVolume()}");
        }
    }
}
