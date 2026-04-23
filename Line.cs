using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Line
    {
        private double a;
        private double b;
        public Line(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public double GetA() { return this.a; }
        public void SetA(double a) { this.a = a; }
        public double GetB() { return this.b; }
        public void SetB(double b) { this.b = b; }

        public Line() : this(1, 0) { }

        public Line(double a, Point p) : this(a, p.GetY() - a * p.GetX()) { }

        public Line(Line l) : this(l.a, l.b) { }

        public Line(Point p1, Point p2) : this((p2.GetY() - p1.GetY()) / (p2.GetX() - p1.GetX()), p1) { }

        public Point Yintercept()
        {
            return new Point(0, GetB());
        }

        public Point[] Xintercept()
        {
            if (GetA() == 0)
                return null;
            return new Point[] { new Point(-this.GetB() / this.GetA(), 0) };
        }

        public double GetY(double x) { return this.GetA() * x + this.GetB(); }

        public bool IsOnLine(Point p)
        {
            if (p.GetY() == this.GetA() * p.GetX() + this.GetB())
                return true;
            return false;
        }

        public int LineStatus(Line line)
        {
            if (line.GetA() == this.GetA() && line.GetB() == this.GetB())
                return -1;
            if (line.GetA() == this.GetA())
                return 0;
            return 1;
        }

        public Point LineIntercept(Line line)
        {
            double x, y;
            if (this.LineStatus(line) == 1)
            {
                x = (line.GetB() - this.GetB()) / (this.GetA() - line.GetA());
                y = this.GetA() * x + this.GetB();
                return new Point(x, y);
            }
            else
                return null;
        }

        public Line Perpendicular(Point p)
        {
            if (this.GetA() == 0)
                return null;
            double a = -1 / this.GetA();
            Line line = new Line(a, p);
            return line;
        }
        public double DistanceFromPoint(Point p)
        {
            Line l = this.Perpendicular(p);
            Point po = this.LineIntercept(l);
            return p.Distance(po);
        }
        public double AreaWithX(Line line)
        {
            if (this.LineStatus(line) != 1)
                return 0;
            Point PIn = this.LineIntercept(line);
            if (PIn == null)
                return 0;
            Point[] arr1 = this.Xintercept();
            Point[] arr2 = line.Xintercept();
            Point pX1 = arr1[0];
            Point pX2 = arr2[0];
            double baseLen = Math.Abs(pX1.GetX() - pX2.GetX());
            double height = Math.Abs(PIn.GetY());
            return (baseLen * height) / 2.0;
        }
        public double[] TriangleAnglesWithX(Line line)
        {
            if (this.LineStatus(line) != 1)
                return null;
            double m1 = this.GetA();
            double m2 = line.GetA();

            double angleB = Math.Atan(Math.Abs((m1 - m2) / (1 + m1 * m2)));
            double angle1 = Math.Abs(Math.Atan(m1));
            double angle2 = Math.Abs(Math.Atan(m2));
            return new double[] { angleB, angle1, angle2 };
        }

        public override string ToString()
        {
            return $"f(x) = {this.a}x + {this.b}";
        }
        public static void UnitTest()
        {
            Line l1 = new Line(1, 0);
            Line l2 = new Line(-1, 4);

            Console.WriteLine(l1);
            Console.WriteLine(l2);
            Console.WriteLine(l1.Yintercept());
            Console.WriteLine(l2.Xintercept());
            Console.WriteLine(l1.GetY(5));

            Point pTest = new Point(2, 2);
            Console.WriteLine(l1.IsOnLine(pTest));
            Console.WriteLine(l1.LineStatus(l2));

            Point intersect = l1.LineIntercept(l2);
            Console.WriteLine(intersect);

            Point pEx = new Point(0, 4);
            Line perp = l1.Perpendicular(pEx);
            Console.WriteLine(perp);
            Console.WriteLine(l1.DistanceFromPoint(pEx));

            Console.WriteLine(l1.AreaWithX(l2));

            double[] angles = l1.TriangleAnglesWithX(l2);
            Console.WriteLine(angles[0]);
            Console.WriteLine(angles[1]);
            Console.WriteLine(angles[2] + "Sasha");
        }
    }
}
