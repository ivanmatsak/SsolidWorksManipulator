using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Media.Media3D;

namespace Main._1
{
    public class MathHelper
    {

        public static CoordinateSystem DCS = new CoordinateSystem();

        public static double GetRadians(double degrees) {

            return degrees * Math.PI / 180f;

        } 

        public static double GetDegrees(double radians)
        {

            return radians * 180f / Math.PI;

        }

        public static Point3D GetCenter(IEnumerable<Point3D> points) {
            double x = 0;
            double y = 0;
            double z = 0;

            foreach (Point3D point in points) {
                x += point.X;
                y += point.Y;
                z += point.Z;
            }

            x /= points.Count();
            y /= points.Count();
            z /= points.Count();

            return new Point3D(x,y,z);
        }

        public static System.Windows.Point GetCenter(IEnumerable<System.Windows.Point> points)
        {
            double x = 0;
            double y = 0;
            double z = 0;

            foreach (System.Windows.Point point in points)
            {
                x += point.X;
                y += point.Y;
            }

            x /= points.Count();
            y /= points.Count();

            return new System.Windows.Point(x, y);
        }

        public static IEnumerable<System.Windows.Point> SetCenter(IEnumerable<System.Windows.Point> points, System.Windows.Point newCenter) {

            List<System.Windows.Point> result = new List<System.Windows.Point>();

            System.Windows.Point center = GetCenter(points);

            System.Windows.Vector offset = center - newCenter;

            foreach (System.Windows.Point point in points) {

                result.Add(point- offset);

            }

            return result;

        }

        public static Vector3D GetVector(Point3D first, Point3D second) {

            return Point3D.Subtract(first, second);
        
        }

        public static Vector3D GetNormal(Vector3D first, Vector3D second) {

            Vector3D result = Vector3D.CrossProduct(first, second);

            result.Normalize();

            return result;
        }


        public static IEnumerable<System.Windows.Point> SortedPoints(System.Windows.Point[] points)
        {
            return points.Take(1).Union(
                points.Skip(1).OrderBy(point =>
                    Math.Atan2(point.X - points[0].X, point.Y - points[0].Y)));
        }

    }


    public class GiftWrapping
    {
        public static List<System.Windows.Point> ConvexHull(List<System.Windows.Point> points)
        {
            if (points.Count < 3)
            {
                throw new ArgumentException("At least 3 points reqired", "points");
            }

            List<System.Windows.Point> hull = new List<System.Windows.Point>();

            // get leftmost point
            System.Windows.Point vPointOnHull = points.Where(p => p.X == points.Min(min => min.X)).First();

            System.Windows.Point vEndpoint;

            do
            {
                hull.Add(vPointOnHull);
                vEndpoint = points[0];

                for (int i = 1; i < points.Count; i++)
                {
                    if ((vPointOnHull == vEndpoint)
                        || (Orientation(vPointOnHull, vEndpoint, points[i]) == 1)
                        )
                    {
                        vEndpoint = points[i];
                    }

                }

                vPointOnHull = vEndpoint;

            }
            while (vEndpoint != hull[0]);

            return hull;
        }

        private static int Orientation(System.Windows.Point p1, System.Windows.Point p2, System.Windows.Point p)
        {
            // Determinant
            double Orin = (p2.X - p1.X) * (p.Y - p1.Y) - (p.X - p1.X) * (p2.Y - p1.Y);

            if (Orin > 0)
                return -1; //          (* Orientation is to the left-hand side  *)
            if (Orin < 0)
                return 1; // (* Orientation is to the right-hand side *)

            return 0; //  (* Orientation is neutral aka collinear  *)
        }
    
    }
}
