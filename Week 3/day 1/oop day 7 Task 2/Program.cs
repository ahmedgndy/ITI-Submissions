namespace oop_day_7_Task_2
{
    class Complex
    {
        public int Real;
        public int Imag;

        public Complex(int real = 0, int imag = 0)
        {
            Real = real;
            Imag = imag;
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imag - c2.Imag);
        }

        public static Complex operator -(int number, Complex c)
        {
            return new Complex(number - c.Real, -c.Imag);
        }

        public static Complex operator -(Complex c, int number)
        {
            return new Complex(c.Real - number, c.Imag);
        }

      

        public static Complex operator -(Complex c)
        {
            return new Complex(-c.Real, -c.Imag);
        }

        public static bool operator ==(Complex c1, Complex c2)
        {
            return c1.Real == c2.Real && c1.Imag == c2.Imag;
        }

        public static bool operator !=(Complex c1, Complex c2)
        {
            return !(c1 == c2);
        }

        public static bool operator >(Complex c1, Complex c2)
        {
            return c1.Magnitude() > c2.Magnitude();
        }

        public static bool operator >=(Complex c1, Complex c2)
        {
            return c1.Magnitude() >= c2.Magnitude();
        }

        public static bool operator <(Complex c1, Complex c2)
        {
            return c1.Magnitude() < c2.Magnitude();
        }

        public static bool operator <=(Complex c1, Complex c2)
        {
            return c1.Magnitude() <= c2.Magnitude();
        }

        public static implicit operator int(Complex c)
        {
            return c.Real;
        }

        public static explicit operator string(Complex c)
        {
            return $"{c.Real} + {c.Imag}i";
        }

        public static implicit operator bool(Complex c)
        {
            return c.Real != 0 || c.Imag != 0;
        }

        public double Magnitude()
        {
            return Math.Sqrt(Real * Real + Imag * Imag);
        }

        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                return this == (Complex)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Real ^ Imag;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(5, 3);
            Complex c2 = new Complex(2, 1);

            Complex c3 = c1 - c2;
            Console.WriteLine("c1 - c2 = " + c3);

            c3 = 7 - c2;
            Console.WriteLine("7 - c2 = " + c3);

            c3 = c2 - 7;
            Console.WriteLine("c2 - 7 = " + c3);

            c1 -= c2;
            Console.WriteLine("c1 -= c2 → c1 = " + c1);

            Console.WriteLine("-c1 = " + (-c1));

            Console.WriteLine("c1 == c2? " + (c1 == c2));
            Console.WriteLine("c1 != c2? " + (c1 != c2));

            Console.WriteLine("c1 > c2? " + (c1 > c2));
            Console.WriteLine("c1 >= c2? " + (c1 >= c2));
            Console.WriteLine("c1 < c2? " + (c1 < c2));
            Console.WriteLine("c1 <= c2? " + (c1 <= c2));

            int realPart = c1;
            Console.WriteLine("(int)c1 = " + realPart);

            string complexStr = (string)c1;
            Console.WriteLine("(string)c1 = " + complexStr);

            if (c1)
                Console.WriteLine("c1 is not zero");
            else
                Console.WriteLine("c1 is zero");
        }
    }
  }

