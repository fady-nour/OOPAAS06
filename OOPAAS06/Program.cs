using static OOPAAS06.Point3D;

namespace OOPAAS06
{
    internal class Program
    {
        static void Main(string[] args) {
            //    #region q1
            //    Point3D P1 = ReadPointFromUser("P1");
            // Point3D P2 = ReadPointFromUser("P2");

            //Console.WriteLine(P1);
            //Console.WriteLine(P2);


            //    Console.WriteLine(P1 == P2
            //        ? "P1 and P2 reference are the same"
            //        : "P1 and P2 reference are different");


            //    Point3D[] points = {
            //        new Point3D(5, 2, 1),
            //        new Point3D(3, 4, 7),
            //        new Point3D(3, 1, 0),
            //        new Point3D(7, 8, 9)
            //    };

            //Array.Sort(points);
            //    Console.WriteLine("\nSorted Points:");
            //    foreach (var p in points)
            //        Console.WriteLine(p);

            //    Point3D cloned = (Point3D)P1.Clone();
            //Console.WriteLine($"\nCloned Point: {cloned}");
            //    #endregion
            #region Q2
            double a = 50, b = 77;

            Console.WriteLine($"Add: {Maths.Add(a, b)}");
            Console.WriteLine($"Subtract: {Maths.Subtract(a, b)}");
            Console.WriteLine($"Multiply: {Maths.Multiply(a, b)}");
            Console.WriteLine($"Divide: {Maths.Divide(a, b)}");
            #endregion
        }


        #region q1


        static Point3D ReadPointFromUser(string pointName)
        {
            double x = ReadDouble($"{pointName} - Enter X: ");
            double y = ReadDouble($"{pointName} - Enter Y: ");
            double z = ReadDouble($"{pointName} - Enter Z: ");
            return new Point3D(x, y, z);
         
        }   static double ReadDouble(string message)
        {
            double value;
            Console.Write(message);
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                Console.Write("Invalid input, try again: ");
            }
            return value;
        }
        #endregion

    }
}
