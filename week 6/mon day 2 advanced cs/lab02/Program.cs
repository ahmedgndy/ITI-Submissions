using System.Diagnostics.SymbolStore;

namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(10, 10, 10);
            Console.WriteLine( p1.ToString() );

            string pointToString = (string) new Point3D(10 , 35 , 10);
            Console.WriteLine(pointToString);

            int x = ReadInt("x: ");
            int y = ReadInt("Y: ");
            int z = ReadInt("Z: ");

            Point3D p2 = new Point3D(x, y, z);
            Console.WriteLine($" point:  {p2.ToString()} created ");

            x = ReadInt2("x: ");
            y = ReadInt2("Y: ");
            z = ReadInt2("Z: ");

            Point3D p3 = new Point3D(x, y, z);
            Console.WriteLine($" point:  {p3.ToString()} created ");

            if (p2 == p3) { 
            
            } //ref to ref 

            if (p3.Equals(p2))
            {
                Console.WriteLine("they are EQual");
            }

        }

        static int ReadInt(string prompt)

        {
            int value;
            while (true)
            {
              Console.WriteLine(prompt);
              if (int.TryParse(Console.ReadLine(), out value))
                    return value;
                Console.WriteLine("inValid Data");
            }
           
        }
        static int ReadInt2(String prompt) {
            int value;
            while(true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    value = int.Parse(Console.ReadLine());
                    return value;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("invalid Data");
                }
            }
        }
    }
}
