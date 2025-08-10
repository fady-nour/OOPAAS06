using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAAS06
{
    #region Q1

    public class Point3D : IComparable<Point3D>, ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D() : this(0, 0, 0) { }
        public Point3D(double x) : this(x, 0, 0) { }
        public Point3D(double x, double y) : this(x, y, 0) { }
        public Point3D(double x, double y, double z)
        {
            X = x; Y = y; Z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(Point3D other)
        {
            if (this.X != other.X)
                return this.X.CompareTo(other.X);
            return this.Y.CompareTo(other.Y);
        }

        public object Clone()
        {
            return new Point3D(this.X, this.Y, this.Z);
        }
    }
    #endregion
    #region Q2
    public static class Maths
        {
            public static double Add(double a, double b) => a + b;
            public static double Subtract(double a, double b) => a - b;
            public static double Multiply(double a, double b) => a * b;
            public static double Divide(double a, double b)
            {
                if (b == 0)
                    return -1;
                return a / b;
            }
        }
#endregion}

