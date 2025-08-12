using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab02
{
    internal class Point3D    {

        public int  X {  get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        
        //chaining Constructore
        public Point3D(int n):this(n, n , n)
        {

        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"x : {X} , y = {Y} , z = {Z}";
        }
        public override bool Equals(object? obj)
        {
            if (obj is Point3D p) { 
               return p.X == this.X && p.Y == this.Y && p.Z == this.Z ;
            }
            return false; 
        }

        public static explicit operator string(Point3D p) { 

           return $"casting to string  x : {p.X} , y = {p.Y} , z = {p.Z}";
        }
    }
}
