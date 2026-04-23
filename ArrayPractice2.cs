using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class ArrayPractice2
    {
        //resistors
        public static void UnitTest()
        {
            //Console.WriteLine(ArrayPractice2.T1(5));
            //string[] strs = { "a", "b" };
            //int[] nums = { 2, 3 };
            //ArrayPractice2.T2(strs, nums);
            //int[] projs = (ArrayPractice2.T3(4));
            //for(int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine(projs[i]);
            //}
            //ArrayPractice2.T12_a();
            //double[] arr = { 9, 5, 3, 2, 1, 11, 1, 1, 2, 3, 11, 12 };  
            //Console.WriteLine(ArrayPractice2.T12_b(arr));
            ArrayPractice2.T12_c();
        }
        private static int T1(int N)
        {
            int[] resistors = new int[N];
            int notProperCount = 0, sum = 0, count = 0, avg = 0;
            for(int i = 0; i < N; i++)
            {
                Console.Write("Enter resistance: ");
                resistors[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < N; i++)
            {
                sum += resistors[i];
                count++;

            }
            avg = sum / count;
            Console.WriteLine($"The average resistance is {avg}.");
            for(int i = 0; i < N; i++)
            {
                if (resistors[i] > 1.1 * avg || resistors[i] < 0.9 * avg) 
                {
                    notProperCount++;
                }
            }
            return notProperCount;
        }
        public static void T2(string[] arr1,int[] arr2)
        {
            int sum = 0, count = 0, avg;
            for(int i = 0; i < arr1.Length; i++)
            {
                sum += arr2[i];
                count++;
            }
            avg = sum / count;
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr2[i] > avg)
                {
                    Console.WriteLine($"{arr1[i]} has been accepted to CS trend.");
                }
            }

            
        }
        public static int[] T3(int N)
        {
            int[] arr = new int[N];
            int[] winners = new int[2];
            int max = 0, secMax = 0;
            int maxI = 0, secMaxI = 0;
            Console.Write("Enter the number of project you're voting for: ");
            int vote = int.Parse(Console.ReadLine());
            while(vote != -1)
            {
                arr[vote - 1] += 1;
                Console.Write("Enter the number of project you're voting for: ");
                vote = int.Parse(Console.ReadLine());
            }
            //max = arr[0];
            //secMax = arr[0];
            for (int i = 0; i < N; i++)
            {
                if (arr[i] > max)
                {
                    secMax = max;
                    max = arr[i];
                    maxI = i + 1;
                }
                else if (arr[i] > secMax)// && arr[i] < max
                {
                    secMax = arr[i];
                    secMaxI = i + 1;
                }
            }
            for(int i = 0; i < 2; i++)
            {
                if (i == 0)
                    winners[i] = maxI;
                else
                    winners[i] = secMaxI;
            }
            return winners;
        }
        //public static int[] T11_a()
        //{

        //}

        public static double T12_a()
        {
            double sum = 0;
            int count = 0;
            Console.WriteLine("Enter score 1-10: ");
            int vote = int.Parse(Console.ReadLine());
            while(vote != -1)
            {
                sum = sum + vote;
                count++;
                Console.WriteLine("Enter score 1-10: ");
                vote = int.Parse(Console.ReadLine());
            }
            if (count > 100)
                return sum / count;
            return 0;
        }
        public static bool T12_b(double[] arr)
        {
            for(int i = 0; i < 11; i++)
            {
                if (arr[i] > 8 && arr[i+1] > 8)
                    return true;
            }
            return false;
        }

        public static void T12_c()
        {
            double[] arr = new double[12];
            for (int i = 0; i < 12; i++)
            {
                arr[i] = ArrayPractice2.T12_a();
            }
            if (ArrayPractice2.T12_b(arr))
                Console.WriteLine("Fun day to all workers!");
            else
                Console.WriteLine("You are not getting anything! ");
        }
    }
}
