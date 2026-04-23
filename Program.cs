using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.Quic;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;

namespace Practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program.T1();
            //Program.T2();
            //Program.T3();
            //Program.T4();
            //Program.T5();
            //Program.T6();
            //Program.T7();
            //Program.T8();
            //Program.T9();

            //Program.Task1();
            //Program.Task2();
            //Program.Task3();
            //Program.Task4();
            //Program.Task5();
            //Program.Task6();
            //Program.Task8();
            //Program.Task10();
            //Program.Task12();
            //Program.Task14();

            //Program.Targil_7_66();
            //Program.Targil_7_67();
            //Program.Targil_7_68();
            //Program.Targil_7_69();
            //Program.Targil_7_70();
            //Program.Targil_47();
            //Program.Targil_48();

            //STFuncs.UnitTest();
            //BasicMix.UnitTest();
            //ArrayPractice.UnitTest();
            //ArrayPractice2.UnitTest();
            //ClassPractice.UnitTest();
            //Point.UnitTest();
            Rational.UnitTest();
            //899371 899373 899271

        }
        static void T1()
        {
            int x, y, z;
            Console.Write("Enter number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            y = int.Parse(Console.ReadLine());
            z = Funcs.MyMax(x, y);
            Console.WriteLine($"Biggest is {z}");
        }
        static void T2()
        {
            double x, y, z;
            Console.Write("Enter number: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            y = double.Parse(Console.ReadLine());
            z = Funcs.MyMin(x, y);
            Console.WriteLine($"Smallest is {z}");
        }
        static void T3()
        {
            double x, z;
            Console.Write("Enter number: ");
            x = double.Parse(Console.ReadLine());
            z = Funcs.MyAbs(x);
            Console.WriteLine($"Absolute is {z}");
        }
        static void T4()
        {
            double x, y, z;
            Console.Write("Enter number: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            y = double.Parse(Console.ReadLine());
            z = Funcs.MyDist(x, y);
            Console.WriteLine($"Distance is {z}");
        }
        static void T5()
        {
            double x, y, z;
            Console.Write("Enter number: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            y = double.Parse(Console.ReadLine());
            z = Funcs.MyAdd(x, y);
            Console.WriteLine($"Sum is {z}");
        }
        static void T6()
        {
            double x, y, z;
            Console.Write("Enter number: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            y = double.Parse(Console.ReadLine());
            z = Funcs.MyDiv(x, y);
            Console.WriteLine($"Division is {z}");
        }
        static void T7()
        {
            int x, y, z;
            Console.Write("Enter number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            y = int.Parse(Console.ReadLine());
            z = Funcs.MyDiv(x, y);
            Console.WriteLine($"Division is {z}");
        }
        static void T8()
        {
            int x, y, z;
            Console.Write("Enter number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            y = int.Parse(Console.ReadLine());
            z = Funcs.MyMin(x, y);
            Console.WriteLine($"Minimum is {z}");
        }
        static void T9()
        {
            int x, y, z;
            Console.Write("Enter base number: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter power: ");
            y = int.Parse(Console.ReadLine());
            z = Funcs.MyPow(x, y);
            Console.WriteLine($"The number powered is {z}");
        }
        static void Task1()
        {
            int month, year, gender, boys = 0, girls = 0;
            bool liable;
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("Birth month : ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Birth year: ");
                year = int.Parse(Console.ReadLine());
                Console.Write("Gender boy=1/girl=2: ");
                gender = int.Parse(Console.ReadLine());
                liable = Funcs.T1(month, year);
                if (liable)
                {
                    if (gender == 1)
                        boys++;
                    else
                        girls++;
                }
            }
            Console.WriteLine($"There are {boys} boys born the first semester of 2009.");
            Console.WriteLine($"There are {girls} girls born the first semester of 2009.");
        }
        static void Task2()
        {
            double age, years, maxSpeed, speed;
            int count = 0;
            for (int i = 0; i < 500; i++)
            {
                Console.Write("Enter your age: ");
                age = double.Parse(Console.ReadLine());
                Console.Write("Enter how many years you have been driving for: ");
                years = double.Parse(Console.ReadLine());
                Console.Write("Enter the maximum speed in your area: ");
                maxSpeed = double.Parse(Console.ReadLine());
                Console.WriteLine($"The driver's max speed is {Funcs.T2(age, maxSpeed, years)}.");
                Console.Write("Enter your speed: ");
                speed = double.Parse(Console.ReadLine());
                if (speed < Funcs.T2(age, maxSpeed, years))
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} drivers drove in a legal speed.");
        }
        static void Task3()
        {
            int years, monthlySpent, costumers = 0, giftC = 0;
            for (int i = 0; i < 5000; i++)
            {
                Console.Write("Enter for how long you have been a member: ");
                years = int.Parse(Console.ReadLine());
                Console.Write("Enter how much you spent this month: ");
                monthlySpent = int.Parse(Console.ReadLine());
                if (monthlySpent > 1200 && years > 3)
                {
                    costumers++;
                    giftC = Funcs.T3(years, monthlySpent) + giftC;
                }
            }
            Console.WriteLine($"There are {costumers} costumers and the total value of the giftcards is {giftC}.");
        }
        static void Task4()
        {
            int age, hours, count = 0;
            for (int i = 0; i < 492; i++)
            {
                Console.Write("Enter your age: ");
                age = int.Parse(Console.ReadLine());
                Console.Write("Enter how many hours you have listened to the music channel: ");
                hours = int.Parse(Console.ReadLine());
                if (Funcs.T4(age) == true && hours > 3)
                    count++;
            }
            Console.WriteLine($"There are {count} people that are between the ages 5-8 and listened to the music channel for 3 hours or more.");
        }
        static void Task5()
        {
            string name;
            int age, count = 0, students, grade1, grade2, grade3;
            Console.Write("How many students are there: ");
            students = int.Parse(Console.ReadLine());
            for (int i = 0; i < students; i++)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
                Console.Write("Enter your first grade: ");
                grade1 = int.Parse(Console.ReadLine());
                Console.Write("Enter your second grade: ");
                grade2 = int.Parse(Console.ReadLine());
                Console.Write("Enter your third grade: ");
                grade3 = int.Parse(Console.ReadLine());
                if (Funcs.T5(grade1, grade2, grade3) >= 3)
                {
                    Console.WriteLine($"{name} is eligable to compete. ");
                    count++;
                }
            }
            Console.WriteLine($"{count} students are aligable to compete.");
        }
        static void Task6()
        {
            int items, count = 0;
            for (int i = 0; i < 850; i++)
            {
                Console.Write("Enter the number of items: ");
                items = int.Parse(Console.ReadLine());
                if (!Funcs.T6(items))
                    count++;
            }
            Console.WriteLine($"The number of costumers who paid for shipping is {count}.");
        }
        static void Task8()
        {
            string twin1, twin2;
            int countM = 0, countF = 0;
            for (int i = 0; i < 1371; i++)
            {
                Console.Write("First twin gender: ");
                twin1 = Console.ReadLine();
                Console.Write("Second twin gender: ");
                twin2 = Console.ReadLine();
                if (Funcs.T8(twin1, twin2) == 'f')
                {
                    countF++;
                }
                else if (Funcs.T8(twin1, twin2) == 'm')
                {
                    countM++;
                }
            }
            if (countF > countM)
                Console.WriteLine("Females");
            else if (countM > countF)
                Console.WriteLine("Males");
            else
                Console.WriteLine("Equal");
        }
        static void Task10()
        {
            int hourStart, hourFinish;
            int mins, minMins;
            Console.Write("Marathon's starter time: ");
            hourStart = int.Parse(Console.ReadLine());
            Console.Write("Marathon's finish time: ");
            hourFinish = int.Parse(Console.ReadLine());
            mins = Funcs.T10(hourStart, hourFinish);
            Console.WriteLine($"The marathaon took the runner {mins} to finish.");
            minMins = mins;
            for (int i = 1; i < 127; i++)
            {
                if (mins < minMins)
                {
                    minMins = mins;
                }
                Console.Write("Marathon's starter time: ");
                hourStart = int.Parse(Console.ReadLine());
                Console.Write("Marathon's finish time: ");
                hourFinish = int.Parse(Console.ReadLine());
                mins = Funcs.T10(hourStart, hourFinish);
                Console.WriteLine($"The marathaon took the runner {mins} to finish.");
            }
            Console.WriteLine($"The least amount of minutes it took to finish the marathon is {minMins}.");
        }
        static void Task12()
        {
            int num;
            for (int i = 1; i < 142; i++)
            {
                Console.Write("Purchased books amount: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine($"The total amount is {Funcs.T12b(num)}");
            }
        }
        static void Task14()
        {
            int count = 0;
            for (int i = 0; i < 980; i++)
            {
                Console.Write("Enter first digit: ");
                int dig = int.Parse(Console.ReadLine());
                int num = Funcs.T14b(dig);
                if (num % 10 == 9)
                    count++;
                Console.WriteLine("The digits you dialed are: " + num);
            }
            Console.WriteLine();
            Console.WriteLine($"{count} calls ended with a voice message.");
        }
        static void Targil_7_66()
        {
            /*
            a.
            *****
            *****
            *****
            *****
            *****

            b.
            *
            **
            ***
            ****
            *****

            c.
            12345
            12345
            12345
            12345
            12345

            d.
            *****
            ****
            ***
            **
            *
  
             */  
        }
        static void Targil_7_67()
        {
            /*
           for (int j = 1; j<=5; j++)
            {
                for (int i =1; i<=j; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            /*
            for (int j = 1; j <= 5; j++)
            {
                for (int i = 5; i >= j; i--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */
            
            /*
        for (int i = -4; i<=4; i++)
        {
            for (int j = 0; Math.Abs(i) >= j; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }    
            /*
            /*
            for (int j = 1; j<=5; j++)
        {
            for (int i = 1; i<=j; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
            */
            /*
            for (int j = 1; j<=5; j++)
        {
            for (int i = 1; i<=j; i++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
            */

            /*
            for (int j = 5; j>=1; j--)
        {
            for (int i = 1; i<=j; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
            */
            /*
            for (int j = 5; j >= 1; j--)
            {
                for (int i = 1; i <= j; i++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            */
            /*
            for (int j = 1; j<=5; j++)
            {
                for (int i = 5; i>=j; i--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            */
            
        }
        static void Targil_7_68()
        {
            const int STUDENT_NUM = 40;
            const int GRADE_NUM = 20;
            double grade;
            double sum = 0;
            double average;
            for (int i = 1; i <= STUDENT_NUM; i++)
            {
                for (int j = 1; j <= GRADE_NUM; j++)
                {
                    Console.WriteLine("Enter next student grade: ");
                    grade = int.Parse(Console.ReadLine());
                    sum = sum + grade;
                }
            }
            Console.WriteLine(sum / 20);
        }
        static void Targil_7_69()
        {
            int rLength=0, maxLength=0, rowNum;
            Console.Write("Insert rows number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i<num; i++)
            {
                Console.Write("Insert a number: ");
                rowNum = int.Parse(Console.ReadLine());
                while (rowNum != -1)
                {
                    rLength++;
                    Console.Write("Insert a number: ");
                    rowNum = int.Parse(Console.ReadLine());
                }
                if (rLength > maxLength)
                {
                    maxLength = rLength;
                }
                Console.WriteLine();
                rLength = 0;
            }
            Console.WriteLine($"The longest row is {maxLength}");
        }
        static void Targil_7_70()
        {
            int min = 0, payment=0, minLastPayment=0, sum=0;
            Console.Write("Insert number of workers: ");
            int workers = int.Parse(Console.ReadLine());
            for (int i = 0; i < workers; i++)
            {
                Console.Write("Insert a payment: ");
                payment = int.Parse(Console.ReadLine());
                for (int j = 0; j < 12; j++)
                {
                    Console.Write("Insert a payment: ");
                    payment = int.Parse(Console.ReadLine());
                    sum += payment;
                }
                if (i==0)
                {
                    min = sum;
                    minLastPayment = payment;
                }
                else if (min > sum)
                {
                    min = sum;
                    minLastPayment = payment;
                }
                    Console.WriteLine();
            }
            Console.WriteLine($"The poorest worker's last payment is {minLastPayment}.");
        }
        static void Targil_47()
        {
            int price, sum = 0, sumMax = 0;
            for(int i = 1; i <= 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Insert a price: ");
                    price = int.Parse(Console.ReadLine());
                    sum += price;
                }
                    if (i == 1)
                    {
                        sumMax = sum;
                    }
                    else if(sum > sumMax)
                    {
                        sumMax = sum;
                    }
                    Console.WriteLine();
 
                Console.WriteLine("Next Shop:");
            }
            Console.WriteLine($"The most expensive's shop sum of 5 items is {sumMax}.");
        }
        
        static void Targil_48()
        {
            double grade, sum = 0, avg = 0, avgMin = 0;
            for (int i = 1; i <= 3; i++)
            {
                sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Insert a grade: ");
                    grade = double.Parse(Console.ReadLine());
                    sum += grade;
                }
                avg = sum / 4;
                if (i == 1)
                {
                    avgMin = avg;   
                }
                else if (avg < avgMin)
                {
                    avgMin = avg;
                }
                Console.WriteLine();
                Console.WriteLine("Next Group:");
            }
            Console.WriteLine($"The average of the group with the lowest average of grades is {avgMin}.");
        }
       
        static void String0()
        {
            int count = 1;
            Console.Write("Type a sentence: ");
            string S = Console.ReadLine();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
        static void Problem1()
        {
            double time, avr = 0, sum = 0, minAvr = 0;
            int count = 0, countLess;
            for(int i = 0; i < 40; i++)
            {
                count++;
                Console.Write("Enter time: ");
                time = double.Parse(Console.ReadLine());
                sum += time;
                avr = sum / count;
                if(avr > minAvr)
                {
                 
                }
 
            }
        }

    }
}