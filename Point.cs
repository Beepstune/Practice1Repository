using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Point
    {
        private double x;
        private double y;
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Point() : this(0, 0)
        {

        }
        public double GetX() { return this.x; }
        void SetX(double x) { this.x = x; }

        public double GetY() { return this.y; }
        void SetY(double y) { this.y = y; }

        public override string ToString()
        {
            string s = $"({this.x}, {this.y})";
            return s;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt(Math.Pow(this.x - p.GetX(), 2) + Math.Pow(this.y - p.GetY(), 2));
        }

        public Point Middle(Point p)
        {
            Point mid = new Point();
            mid.x = (p.GetX() + this.x) / 2;
            mid.y = (p.GetY() + this.y) / 2;
            return mid;
        }
        public double Slope(Point p)
        {
            return ((this.GetY() - p.GetY()) / (this.GetX() - p.GetX()));
        }

        public static Point FarthestDistance(Point[] points)
        {
            double dis;
            Point farthest = points[0];
            double maxDis = Math.Pow(points[0].GetX(), 2) + Math.Pow(points[0].GetY(), 2);
            for (int i = 1; i < points.Length; i++)
            {
                dis = Math.Pow(points[i].GetX(), 2) + Math.Pow(points[i].GetY(), 2);
                if (dis > maxDis)
                {
                    maxDis = dis;
                    farthest = points[i];
                }
            }
            return farthest;
        }

        public static Point[] MiddlePoints(Point[] points)
        {
            double x, y;
            Point[] MidPoints = new Point[points.Length];
            for (int i = 0; i < points.Length; i++)
            {
                x = points[i].GetX() / 2;
                y = points[i].GetY() / 2;
                MidPoints[i] = new Point(x, y);
            }
            return MidPoints;
        }
        public static void UnitTest()
        {
            Point p1 = new Point(8.3, 25.8);
            Point p2 = new Point(5.6, 6.7);
            Console.WriteLine(p1);
            Console.WriteLine(p1.Distance(p2));
            Console.WriteLine(p1.Middle(p2));

            Console.WriteLine(p1.Slope(p2));
            Point[] points = { new Point(1.2, 3.4), new Point(2.3, 4.5), new Point(-3, -5), new Point(-1, 0) };
            Point farthest = Point.FarthestDistance(points);
            Console.WriteLine($"Farthest from origin: {farthest}");
            Point[] midPoints = Point.MiddlePoints(points);
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(midPoints[i]);
            }
        }
    }
}