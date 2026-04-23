using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Practice1
{
    internal class ArrayPractice
    {
        public static void UnitTest()
        {

            //ArrayPractice.Problem_10_19();
            //ArrayPractice.Problem_10_22();
            //ArrayPractice.Problem_10_23_a();
            //ArrayPractice.Problem_10_23_b();
            //ArrayPractice.Problem_10_24();
            //ArrayPractice.Problem_10_31();
            //ArrayPractice.Problem_10_33();
            //ArrayPractice.Problem_10_36();
            //ArrayPractice.Problem_10_37();
            //ArrayPractice.Problem_10_38();
            //ArrayPractice.Problem_10_40();
            //ArrayPractice.Problem_10_41();
            //ArrayPractice.Problem_10_42();
            //ArrayPractice.Targil_1();
            ArrayPractice.Targil_3();
        }

        public static void Problem_10_19()
        {
            int[] tiles = new int[25];
            int tile, dice, playerPos;

            Console.Write("Enter dice value: ");
            dice = int.Parse(Console.ReadLine());
            for (int i = 0; i < tiles.Length; i++)
            {
                Console.Write("Enter current tile: ");
                tiles[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Enter current position 10-15: ");
            playerPos = int.Parse(Console.ReadLine());
            if (dice >= tiles[playerPos + dice])
            {
                playerPos += dice;
            }
            else
            {
                playerPos -= dice;
            }
            Console.WriteLine($"Your current tile number is {playerPos}");
        }
        public static void Problem_10_22()
        {
            //
            //int holder = arr[arr.Length - 1];
            //for(int i = 1; i < arr.Length; i++)
            //{
            //    arr[arr.Length - i] = arr[arr.Length - i - 1];
            //}
            //nums[0] = holder;
        }
        public static void Problem_10_23_a()
        {
            string temp;
            Console.Write("Enter members number: ");
            int members = int.Parse(Console.ReadLine());
            string[] names = new string[members]; ;
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name: ");
                names[i] = Console.ReadLine();
            }
            for (int j = 0; j < 3; j++)
            {
                temp = names[0];
                for (int i = 0; i < names.Length - 1; i++)
                {
                    names[i] = names[i + 1];

                }
                names[names.Length - 1] = temp;
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


        }
        public static void Problem_10_23_b()
        {
            string temp;
            int total, boys, girls;
            Console.Write("Enter girls number: ");
            girls = int.Parse(Console.ReadLine());
            Console.Write("Enter boys number: ");
            boys = int.Parse(Console.ReadLine());
            total = boys + girls;
            string[] names = new string[total]; ;
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Enter name: ");
                names[i] = Console.ReadLine();
            }
            for (int j = 0; j < 3; j++)
            {
                temp = names[girls];
                for (int i = girls; i < total - 1; i++)
                {
                    names[i] = names[i + 1];

                }
                names[names.Length - 1] = temp;
            }
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public static void Problem_10_24()
        {
            int temp;
            Console.Write("Enter array limit: ");
            int limit = int.Parse(Console.ReadLine());
            int[] arr = new int[limit];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter value: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length / 2; i++)
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Problem_10_26()
        {
            //א. 4,5,6

            //9, 19, 39, 31, 3, 4, 6, 5 .ב

            //for (int i = 0; i < arr.Length - 1; i++)
            //arr[i] = arr[i + 1];

            //for (int i = 1; i < arr.Length; i++)
            //arr[i] = arr[i - 1];

            //for (int i = 0; i < arr.Length / 2; i++)
            //arr[i] = arr[i * 2];

        }
        public static void Problem_10_28()
        {
            //The code is incorrect (out of bounds), and it isnt in the right order as expected.

            //double[] arr = new double[50];
            //for (int i = 0; i < arr.Length; i++)
            //    arr[i] = (i+1) / 2;
        }

        public static void Problem_10_29()
        {

            //|i |n |a[i] |if(a[i] + 2 == a[i + 2]) |output|i<n-2 |
            //|0 |10 |3   |true                     |0, 3  |true  |
            //|1 |9 |18   |true                     |1, 18 |true  |
            //|2 |8 |5 |false                       |      |true  |
            //|3 |7 |20 |false                      |      |true  |
            //|4 |6 |2 |false                       |      |true  |
            //|5 |5 |4 |true                        |5, 4  |true  |
            //|6 |4 |5 |false                       |      |true  |
            //|7 |3 |6 |false                       |      |true  |
            //| | | |                               |      |false |

            //The limit in the for loop is n-2 because the condition checks 2 values in indexes after the current one and it would crash
            //the system and it would be an index out of bounds.
        }
        public static void Problem_10_31()
        {
            int max;
            Console.Write("Enter students number: ");
            int students = int.Parse(Console.ReadLine());
            int[] grade1 = new int[students];
            int[] grade2 = new int[students];
            int[] finalGrade = new int[students];
            for (int i = 0; i < grade1.Length; i++)
            {
                Console.Write("Enter first exam grade: ");
                grade1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < grade2.Length; i++)
            {
                Console.Write("Enter second exam grade: ");
                grade2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < finalGrade.Length; i++)
            {
                max = Math.Max(grade1[i], grade2[i]);
                finalGrade[i] = max;
                Console.WriteLine($"First exam grade is {grade1[i]}, second exam grade is {grade2[i]}, your final grade is {finalGrade[i]}");
            }
        }
        public static void Problem_10_33()
        {
            int countOdd = 0, countEven = 0, odd = 0, even = 0;
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[] numList = new int[num];
            for (int i = 0; i < numList.Length; i++)
            {
                Console.Write("Enter number to list: ");
                numList[i] = int.Parse(Console.ReadLine());
            }
            int[] oddNums, evenNums;
            for (int i = 0; i < numList.Length; i++)
            {
                if (numList[i] % 2 == 0)
                    countEven++;
                else
                    countOdd++;
            }
            oddNums = new int[countOdd];
            evenNums = new int[countEven];
            for (int i = 0; i < numList.Length; i++)
            {
                if (numList[i] % 2 == 0)
                {
                    evenNums[even] = numList[i];
                    even++;
                }

                else
                {
                    oddNums[odd] = numList[i];
                    odd++;
                }
            }
            for (int i = 0; i < even; i++)
            {
                Console.WriteLine(evenNums[i]);
            }
            for (int i = 0; i < odd; i++)
            {
                Console.WriteLine(oddNums[i]);
            }
        }
        public static void Problem_10_34()
        {
            Console.Write("Enter first array limit: ");
            int limit1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second array limit: ");
            int limit2 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[limit1];
            int[] arr2 = new int[limit2];
            int max = Math.Max(arr1.Length, arr2.Length);
            for (int i = 0; i < max; i++)
            {

            }
        }
        public static void Problem_10_36()
        {
            int countRooty = 0, countAli = 0, countAviv = 0, countOfir = 0, max;
            string name = "";
            Console.Write("Enter number of students: ");
            int students = int.Parse(Console.ReadLine());
            int[] arr = new int[students];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter the student's number you would like to choose for: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    countRooty++;
                }
                else if (arr[i] == 2)
                {
                    countAli++;
                }
                else if (arr[i] == 3)
                {
                    countAviv++;
                }
                else if (arr[i] == 4)
                {
                    countOfir++;
                }
            }
            max = Math.Max(countRooty, Math.Max(countAli, Math.Max(countAviv, countOfir)));
            if (countRooty == max)
                name = "Rooty";
            else if (countAli == max)
                name = "Ali";
            else if (countAviv == max)
                name = "Aviv";
            else if (countOfir == max)
                name = "Ofir";
            Console.WriteLine($"{name} was chosen to be in the students council.");
        }
        public static void Problem_10_37()
        {
            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 7);
                if (arr[i] == 1)
                {
                    count1++;
                }
                else if (arr[i] == 2)
                {
                    count2++;
                }
                else if (arr[i] == 3)
                {
                    count3++;
                }
                else if (arr[i] == 4)
                {
                    count4++;
                }
                else if (arr[i] == 5)
                {
                    count5++;
                }
                else if (arr[i] == 6)
                {
                    count6++;
                }
            }
            Console.WriteLine($"Number of times each number was rolled: 1 - {count1}, 2 - {count2}, 3 - {count3}, 4 - {count4}, 5 - {count5}, 6 - {count6}");
        }
        public static void Problem_10_38()
        {
            bool found = false;
            int winner = 0;
            int[] arr = new int[7];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(1, 7);
                Console.WriteLine(arr[i]);
            }
            for (int i = 0; i < arr.Length && found != true; i++)
            {
                for (int j = 0; j < i && found != true; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        winner = arr[i];
                        found = true;
                    }
                }
            }
            Console.WriteLine($"The winner is {winner}.");
        }
        public static void Problem_10_40()
        {
            Random rnd = new Random();
            int randomNum, max = 0;
            string randomI, maxColor = "";
            Console.Write("Enter players number: ");
            int players = int.Parse(Console.ReadLine());
            string[] arr = new string[players];
            int[] counts = new int[players];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter color: ");
                arr[i] = Console.ReadLine();
            }
            Console.Write("Press <Enter> to start: ");
            string random = Console.ReadLine();
            while (random != "Q")
            {
                randomNum = rnd.Next(arr.Length);
                randomI = arr[randomNum];
                counts[randomNum]++;
                Console.Write("Press <Enter> to roll again, press <Q> to stop: ");
                random = Console.ReadLine();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (counts[i] > max)
                {
                    max = counts[i];
                    maxColor = arr[i];
                }
            }
            Console.WriteLine($"The color which won is {maxColor}");
        }
        public static void Problem_10_41()
        {
            int[] scores = new int[4];
            int first, second, third, max = 0, maxI = 0;

            Console.Write("Enter number of turns: ");
            int turnsNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < turnsNum; i++)
            {
                Console.Write("Enter first place player's number: ");
                first = int.Parse(Console.ReadLine());
                scores[first - 1] += 7;
                Console.Write("Enter second place player's number: ");
                second = int.Parse(Console.ReadLine());
                scores[second - 1] += 3;
                Console.Write("Enter third place player's number: ");
                third = int.Parse(Console.ReadLine());
                scores[10 - first - second - third -1] -= 4;
            }
            for (int i = 0; i < 4; i++)
            {
                if (scores[i] > max)
                {
                    max = scores[i];
                    maxI = i + 1;
                }
            }
            Console.WriteLine($"The player who won is {maxI}.");
        }
        public static void Problem_10_42()
        {
            int maxMovies = 0, maxCopies = 0, code;
            int[] movieCount = new int[6];
            int[] copyCount = new int[6];
            Console.Write("Enter code: ");
            code = int.Parse(Console.ReadLine());
            while (code != 0)
            {
                movieCount[code / 1000 - 1]++;
                copyCount[code / 1000 - 1] += code % 10;
                Console.Write("Press 0 to stop or enter code again: ");
                code = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 6; i++)
            {
                if (movieCount[i] > movieCount[maxMovies])
                    maxMovies = i;
                if (copyCount[i] > copyCount[maxCopies])
                    maxCopies = i;
            }
            Console.WriteLine($"Class code with biggest number of movies is {maxMovies + 1}.");
            Console.WriteLine($"Class code with biggest number of copies is {maxCopies + 1}.");
        }
        public static void Targil_1()
        {
            int playerScore, maxShot = 1, maxScore = 0;
            int[] scores = new int[5];
            int[] shotType = new int[4];
            Console.Write("Enter player number: ");
            int playerNumber = int.Parse(Console.ReadLine());
            int sum = playerNumber;
            while (playerNumber != 0)
            {
                Console.Write("Enter player's score: ");
                playerScore = int.Parse(Console.ReadLine());
                scores[playerNumber - 1] += playerScore;
                shotType[playerScore]++;
                sum += playerScore;
                Console.WriteLine("=====================================================");
                Console.Write("Enter player number (enter 0 to stop): ");
                playerNumber = int.Parse(Console.ReadLine());

            }
            maxScore = scores[0];
            for (int i = 1; i < 5; i++)
            {
                if (scores[i] > maxScore)
                {
                    maxScore = scores[i];
                }
            }
            Console.Write("Player with highest points: ");
            for (int i = 0; i < 5; i++)
            {
                if (scores[i] == maxScore)
                {
                    Console.Write((i + 1) + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Total points of the group in the game: {sum}");
            for (int i = 2; i <= 3; i++)
            {
                if (shotType[i] > shotType[maxShot])
                    maxShot = i;
            }
            Console.WriteLine($"Most common shot type: {maxShot}");

            Console.Write("Players with no points: ");
            for (int i = 0; i < 5; i++)
            {
                if (scores[i] == 0)
                    Console.Write((i + 1) + " ");
            }
        }
        public static void Targil_2()
        {
            //a. 5, 3
            //b. 12, 20, 22, 74, 9, 7, 5, 4, 8, 88 
            //c. מטרת קטע הקוד היא לספור את כמות המספרים הזוגיים והאי - זוגיים במערך ולהדפיס את הכמויות.
        }
        public static void Targil_3()
        {
            int letter = 'a';
            int[] counts = new int[26];
            Console.Write("Enter char: ");
            char ch = char.Parse(Console.ReadLine());
            while (ch != '*')
            {
                counts[(int)ch-letter]++;
                Console.Write("Enter char (type * to stop): ");
                ch = char.Parse(Console.ReadLine());
            }
            for(int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine($"The letter {(char)(letter+i)} has been written {counts[i]} times");
            }
        }
        public static void Targil_4()
        {
            int medID, amount, max;
            int[] groupSums = new int[4];
            int[] medIDs = new int[150];

            for (int i = 0; i < medIDs.Length; i++)
            {
                medIDs[i] = i + 1;
            }

            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            while (age != -1)
            {
                Console.Write("Enter medicine ID: ");
                medID = int.Parse(Console.ReadLine());
                medIDs[medID - 1] = -1;
                Console.Write("Enter amount of medicine taken: ");
                amount = int.Parse(Console.ReadLine());
                if (age >= 0 && age <= 10)
                {
                    groupSums[0] += amount;
                }
                else if (age >= 11 && age <= 30)
                {
                    groupSums[1] += amount;
                }
                else if (age >= 31 && age <= 50)
                {
                    groupSums[2] += amount;
                }
                else if (age >= 51)
                {
                    groupSums[3] += amount;
                }
                Console.Write("Enter age: ");
                age = int.Parse(Console.ReadLine());
            }
            max = groupSums[0];
            for (int i = 0; i < 4; i++)
            {
                if (groupSums[i] > max)
                {
                    max = groupSums[i];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                if (groupSums[i] == max)
                {
                    if (i == 0)
                        Console.WriteLine($"Age group 0-10 has taken the most amount of medicine.");
                    else if (i == 1)
                        Console.WriteLine($"Age group 11-30 has taken the most amount of medicine.");
                    else if (i == 2)
                        Console.WriteLine($"Age group 31-50 has taken the most amount of medicine.");
                    else
                        Console.WriteLine($"Age group 51+ has taken the most amount of medicine.");
                }
            }
            Console.WriteLine("The medicine that were not taken by ids are: ");
            for (int i = 0; i < medIDs.Length; i++)
            {
                if (medIDs[i] != -1)
                    Console.Write(medIDs[i] + ", ");
            }
            //  השתמשתי בתבנית סכום כדי להוסיף את הסכום הכולל לכל קבוצה בנפרד ולשמור על הערכים בלי לאבד אותם והשתמשתי
            //  בתבנית מקסימום עם שילוב של ערכי המערך כדי למצוא את הקבוצות שלקחו את כמות התרופות הגדולה ביותר ואחרי זה הדפסתי אותם בעזרת לולאה ותנאים
            //   שידפיסו הודעה לכל קבוצה בנפרד שהכמות שהיא צרכה הכי גדולה גם אם יש כמה כאלה.
        }
        public static void Targil_5()
        {
            int[] rooms = { 14, 11, 10, 8, -1, 6, -1, 2, 0, 13, 4, -1, 15, 1, 7, 5 }; ;
            int current;
            Console.Write("Enter first room number: ");
            current = int.Parse(Console.ReadLine());
            while (rooms[current] != -1)
            {
                current = rooms[current];
            }
            Console.WriteLine($"The treasure is in room {current}.");
        }
        //public static void UnitTest()
        //{
        //    ArrayPractice2.a();
        //    //ArrayPractice2.b();
        //}
        //public static void a()
        //{
        //    string str = "Yakov!!!";
        //    string str2 = str.ToUpper();
        //    Console.WriteLine(str2);
        //    Console.WriteLine(str.CompareTo(str2));
        //}

        // nonstatic on the etzem
    }
}