using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Rational
    {
        private int x;
        private int y;
        public Rational(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Rational(Rational other) : this(other.x, other.y) { }

        public Rational(int num) : this(num, 1) { }

        int GetNumerator() { return this.x; }
        int GetDenom() { return this.y; }

        double GetDecimal() { return (double)GetNumerator() / GetDenom(); }
        public bool IsEqual(Rational num)
        {
            return (this.GetNumerator() * num.GetDenom() == num.GetNumerator() * this.GetDenom());
        }
        public Rational Multiply(Rational num)
        {
            return new Rational(this.GetNumerator() * num.GetNumerator(), this.GetDenom() * num.GetDenom());
        }
        public Rational Divide(Rational num)
        {
            return new Rational(this.GetNumerator() * num.GetDenom(), num.GetNumerator() * this.GetDenom());
        }

        public override string ToString()
        {
            return $"{GetNumerator()} / {GetDenom()}";
        }
        public Rational Add(Rational num)
        {
            return new Rational(this.GetNumerator() * num.GetDenom() + num.GetNumerator() * this.GetDenom(), num.GetDenom() * this.GetDenom());
        }
        public Rational Subtract(Rational num)
        {
            return new Rational(this.GetNumerator() * num.GetDenom() - num.GetNumerator() * this.GetDenom(), num.GetDenom() * this.GetDenom());
        }
        public void Reduct()
        {
            int tempX = this.x, tempY = this.y, temp;
            while (tempY != 0)
            {
                temp = tempY;
                tempY = tempX % tempY;
                tempX = temp;
            }
            this.x /= tempX;
            this.y /= tempX;
        }
        public static void UnitTest()
        {
            Rational r = new Rational(391, 437);
            Rational r2 = new Rational(1, 4);
            Console.WriteLine(r.IsEqual(r2));
            Console.WriteLine(r.Multiply(r2));
            Console.WriteLine(r.Divide(r2));
            Console.WriteLine(r.Add(r2));
            Console.WriteLine(r.Subtract(r2));
            Console.WriteLine(r.GetDecimal());
            r.Reduct();
            Console.WriteLine(r);
        }
    }
}