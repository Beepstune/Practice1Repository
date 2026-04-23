using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Funcs
    {
        public static void UnitTest()
        {
            //Console.WriteLine(Calc371(90, 95));
            //Console.WriteLine(Calc371(90, 94));
            //Console.WriteLine(Calc3(67, 80));
            //Console.WriteLine(Calc3(71, 80));
            //Console.WriteLine(Calc5(67, 80));
            //Console.WriteLine(Calc5(71, 80));
            string str = FinalString(80, 90, 80, 87, 100);
            Console.WriteLine(str);
        }
        private static int Calc371(int magen371, int bagrut371)
        {
            return (int)(magen371 * 0.3 + bagrut371 * 0.7 + 0.5);
        }
        private static int Calc3(int final371, int proj)
        {
            return (int)(0.6 * final371 + 0.4 * proj + 0.5);
        }
        private static int Calc271(int magen271, int bagrut271)
        {
            return (int)(magen271 * 0.4 + bagrut271 * 0.6 + 0.5);
        }
        private static bool Has5(int bagrut271)
        {
            return bagrut271 >= 55;
        }
        private static int Calc5(int final371, int final3)
        {
            return (int)(final371 * 0.4 + final3 * 0.6 + 0.5);
        }
        public static string FinalString(int magen371, int bagrut371, int magen271, int bagrut271, int proj)
        {
            string s = "";
            int f371 = Calc371(magen371, bagrut371);
            int f3 = Calc3(f371, proj);
            int final;
            if (Has5(bagrut271))
            {
                s = "You got 5 units in CS!\n";
                int f271 = Calc271(magen271, bagrut271);
                final = Calc5(f271, f3);
            }
            else
            {
                s = "You got 3 units in CS!\n";
                final = f3;
            }
            s += "Your final grade is: " + final;
            return s;
        }




        public static int MyMax(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static double MyMin(double a, double b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
        public static double MyAbs(double a)
        {
            if (a < 0)
                return a * -1;
            return a;
        }
        public static double MyDist(double a, double b)
        {
            if (a > b)
                return a - b;
            else
                return b - a;

        }
        public static double MyAdd(double a, double b)
        {
            return a + b;
        }
        public static double MyDiv(double a, double b)
        {
            return a / b;
        }
        public static int MyDiv(int a, int b)
        {
            return a / b;
        }
        public static int MyMin(int a, int b)
        {
            if (b > a)
                return a;
            else
                return b;
        }
        public static int MyPow(int a, int b)
        {
            int c = 1;
            while (b > 0)
            {
                c *= a;
                b--;
            }
            return c;
        }
        public static bool T1(int month, int year)
        {
            return (month >= 1 && month <= 6 && year == 2009);
        }
        public static double T2(double age, double maxSpeed, double years)
        {
            if (age < 24 && years < 2)
                return maxSpeed - 10;
            return maxSpeed;

        }
        public static int T3(int years, int monthlySpent)
        {
            if (monthlySpent > 1200 && years > 3)
            {
                if (years < 8)
                    return 50 * years;
                return 100 * years;
            }
            return 0;
        }
        public static bool T4(int age)
        {
            if (age >= 15 && age <= 18)
                return true;
            return false;

        }
        public static int T5(int grade1, int grade2, int grade3)
        {
            int count = 0;
            if (grade1 > 90)
            {
                count++;
                if (grade2 > 90)
                {
                    count++;
                    if (grade3 > 90)
                        count++;
                }
            }
            return count;
        }
        public static bool T6(int items)
        {
            int totalP = 0, price;
            for (int i = 0; i < items; i++)
            {
                Console.Write("Insert the item's price: ");
                price = int.Parse(Console.ReadLine());
                totalP += price;
            }
            if (totalP > 150)
                return true;
            return false;
        }
        public static char T8(string twin1, string twin2)
        {
            if (twin1 == "female" & twin2 == "female")
            {
                return 'f';
            }
            else if (twin1 == "male" & twin2 == "male")
            {
                return 'm';
            }
            return 'v';
        }
        public static int T10(int first, int second)
        {

            return (second / 100 - first / 100) * 60 + (second % 100 - first % 100);

        }
        public static double T12a(double price1, double price2)
        {
            if (price1 < price2)
                return price2 * 0.5 + price1;
            return price1 * 0.5 + price2;
        }
        public static double T12b(int bookN)
        {
            double price1, price2, price3;
            Console.Write("Enter first price: ");
            price1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second price: ");
            price2 = double.Parse(Console.ReadLine());
            if (bookN == 2)
            {
                return T12a(price1, price2);
            }
            else if (bookN == 3)
            {
                Console.Write("Enter third price: ");
                price3 = double.Parse(Console.ReadLine());
                if (price2 < price1)
                {
                    if (price2 < price3)
                        return price1 + price3;
                }
                else if (price1 < price2)
                {
                    if (price1 < price3)
                        return price2 + price3;
                }
            }
            return price1 + price2;
        }
        public static int T14a(int num, int digit)
        {
            return (num * 10) + digit;
        }
        public static int T14b(int firstD)
        {
            int num = firstD;
            Console.Write("Enter next digit: ");
            int addD = int.Parse(Console.ReadLine());
            while (addD != 9 && addD != 0)
            {
                num = T14a(num, addD);
                Console.Write("Enter next digit: ");
                addD = int.Parse(Console.ReadLine());
            }

            return T14a(num, addD);
        }
    }
}