using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Rectangle
    {
        private Point bottomLeft;
        private Point topRight;
        public Rectangle(Point bottomLeft, Point topRight)
        {
            this.bottomLeft = bottomLeft;
            this.topRight = topRight;
        }

        public Rectangle(Point bottomLeft, double width, double height)
        {
            this.bottomLeft = bottomLeft;
            this.topRight = new Point(bottomLeft.GetX() + width, bottomLeft.GetY() + height);
        }
        double GetArea()
        {
            double width = topRight.GetX() - bottomLeft.GetX();
            double height = topRight.GetY() - bottomLeft.GetY();
            return width * height;
        }
        double GetPerimeter()
        {
            double width = topRight.GetX() - bottomLeft.GetX();
            double height = topRight.GetY() - bottomLeft.GetY();
            return (2 * (width + height));
        }

        public void Move(double deltaX, double deltaY)
        {
            bottomLeft = new Point(bottomLeft.GetX() + deltaX, bottomLeft.GetY() + deltaY);
            topRight = new Point(topRight.GetX() + deltaX, topRight.GetY() + deltaY);
        }

        public override string ToString()
        {
            return $"Rectangle \n bottom-left point = ({bottomLeft.GetX()}, {bottomLeft.GetY()}) \n top-right point = ({topRight.GetX()}, {topRight.GetY()})";
        }

        public bool PointIsIn(Point P)
        {
            double x = P.GetX();
            double y = P.GetY();
            if (x >= bottomLeft.GetX() && x <= topRight.GetX() && y >= bottomLeft.GetY() && y <= topRight.GetY())
            {
                return true;
            }
            return false;
        }

        public double Distance(Rectangle r)
        {
            Point center1 = bottomLeft.Middle(topRight);
            Point center2 = r.bottomLeft.Middle(r.topRight);
            return center1.Distance(center2);
        }

        public static void UnitTest()
        {
            Point p1 = new Point(2, 1);
            Point p2 = new Point(7, 5);
            Point p3 = new Point(3, 4);
            Rectangle r = new Rectangle(p1, p2);
            Rectangle r2 = new Rectangle(p2, p3);
            r.Move(-1, 2);
            Console.WriteLine(r);
            Console.WriteLine(r.PointIsIn(p1));
            Console.WriteLine(r.PointIsIn(p3));
            Console.WriteLine(r.Distance(r2));
        }
    }
}