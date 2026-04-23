using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Parabula
    {
        private double a;
        private double b;
        private double c;

        public double GetA() { return this.a; }
        public void SetA(double a) { this.a = a; }
        public double GetB() { return this.b; }
        public void SetB(double b) { this.b = b; }
        public double GetC() { return this.c; }
        public void SetC(double c) { this.c = c; }
        public Parabula(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Parabula(double p, double k)
        {
            this.a = 1;
            this.b = -2 * p;
            this.c = p * p - k;
        }
        public Point YIntercept()
        {
            return new Point(0, this.GetC());
        }
        public Point[] Xintercept()
        {
            Point[] pArr = new Point[2];
            double x1, x2, delta = (this.GetB() * this.GetB() - 4 * this.GetA() * this.GetC());
            if (delta < 0)
                return null;
            x1 = (-this.GetB() + Math.Sqrt(delta)) / (2 * GetA());
            pArr[0] = new Point(x1, 0);
            if (delta == 0)
            {
                pArr[1] = null;
                return pArr;
            }
            x2 = (-this.GetB() - Math.Sqrt(delta)) / (2 * GetA());
            pArr[1] = new Point(x2, 0);
            return pArr;
        }
        public double GetY(double x)
        {
            return this.GetA() * x * x + this.GetB() * x + this.GetC();
        }
        public bool IsOnParabula(Point p)
        {
            return p.GetY() == this.GetY(p.GetX());
        }
        public Point Extreme()
        {
            double x, y;
            x = -this.GetB() / (2 * this.GetA());
            y = this.GetY(x);
            return new Point(x, y);
        }
        public Line Tangent(double xC)
        {
            double m = 2 * this.GetA() * xC + this.GetB();
            double yC = this.GetY(xC);
            Point p = new Point(xC, yC);
            return new Line(m, p);
        }
        public Point[] InterceptLine(Line ln)
        {
            double x, x1, x2;
            Point[] pArr = { null, null };
            double a = this.GetA();
            double b = this.GetB() - ln.GetA();
            double c = this.GetC() - ln.GetB();
            double delta = (b * b) - (4 * a * c);
            if (delta < 0)
                return pArr;
            if (delta == 0)
            {
                x = -b / (2 * a);
                pArr[0] = new Point(x, this.GetY(x));
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                pArr[0] = new Point(x1, this.GetY(x1));
                pArr[1] = new Point(x2, this.GetY(x2));
            }
            return pArr;
        }
        public Line PerpendicularFromPoint(Point p, double xC)
        {
            Line tangentLine = this.Tangent(xC);
            return tangentLine.Perpendicular(p);
        }

        public Point[] InterceptParabola(Parabula par)
        {
            double delta, x, x1, x2;
            double a = this.GetA() - par.GetA();
            double b = this.GetB() - par.GetB();
            double c = this.GetC() - par.GetC();
            if (a == 0)
                return null;
            delta = (b * b) - (4 * a * c);
            if (delta < 0) return null;
            Point[] pArr = { null, null };

            if (delta == 0)
            {
                x = -b / (2 * a);
                pArr[0] = new Point(x, this.GetY(x));
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                pArr[0] = new Point(x1, this.GetY(x1));
                pArr[1] = new Point(x2, this.GetY(x2));
            }
            return pArr;
        }

        public double ExtremeArea()
        {
            Point[] intercepts = this.Xintercept();
            if (intercepts == null || intercepts[1] == null)
                return 0;
            double baseLen = Math.Abs(intercepts[0].GetX() - intercepts[1].GetX());
            Point v = this.Extreme();
            double height = Math.Abs(v.GetY());
            return (baseLen * height) / 2.0;
        }

        public double ExtremeArea(Line ln)
        {
            Point[] intercepts = this.InterceptLine(ln);
            if (intercepts == null || intercepts[1] == null)
                return 0;
            double bLen = intercepts[0].Distance(intercepts[1]);
            Point v = this.Extreme();
            double height = ln.DistanceFromPoint(v);

            return (bLen * height) / 2.0;
        }
        public override string ToString()
        {
            string str = "f(x) = ";
            if (this.GetA() == 1)
                str += "x^2";
            else if (this.GetA() == -1)
                str += "-x^2";
            else
                str += this.GetA() + "x^2";
            if (this.GetB() > 0)
                str += " + " + this.GetB() + "x";
            else if (this.GetB() < 0)
                str += " - " + Math.Abs(this.GetB()) + "x";
            if (this.GetC() > 0)
                str += " + " + this.GetC();
            else if (this.GetC() < 0)
                str += " - " + Math.Abs(this.GetC());
            return str;
        }
        public static void UnitTest()
        {
            Parabula p1 = new Parabula(1, -5, 6);
            Parabula p2 = new Parabula(3, 2, 1);
            Line l1 = new Line(1, 0);
            Point pOut = new Point(0, 0);
            Point[] xPoints = p1.Xintercept();
            Console.WriteLine(xPoints[0]);
            Console.WriteLine(xPoints[1]);
            Console.WriteLine(p1.Extreme());
            Console.WriteLine(p1.Tangent(2));
            Console.WriteLine(p1.PerpendicularFromPoint(pOut, 2));
            Point[] lInt = p1.InterceptLine(l1);
            Console.WriteLine(lInt[0]);
            Point[] pInt = p1.InterceptParabola(p2);
            Console.WriteLine(pInt[0]);
            Console.WriteLine(p1.ExtremeArea());
            Console.WriteLine(p1.ExtremeArea(l1));
            Console.WriteLine(p1);
        }

    } 
}

