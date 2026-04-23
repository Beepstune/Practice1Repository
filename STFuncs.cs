using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class STFuncs
    {
        public static void UnitTest()
        {
            //Console.WriteLine(STFuncs.Func1("Hello", 'e'));
            //Console.WriteLine(STFuncs.Func2("Hello", "Hello"));
            //Console.WriteLine(STFuncs.Func3("Hello Josh", "Hello Fosh"));
            //Console.WriteLine(STFuncs.Func4("Josh", "Itay"));
            //Console.WriteLine(STFuncs.Func5("Hello"));
            //Console.WriteLine(STFuncs.Func6_a('a'));
            //Console.WriteLine(STFuncs.Func6_b("HellO"));
            //Console.WriteLine(STFuncs.Func7("HelLo", 'l'));
            //Console.WriteLine(STFuncs.Func8("Heggo", 'l'));
            //Console.WriteLine(STFuncs.Func9("Hell", "Hello"));
            //Console.WriteLine(STFuncs.Func10("Josh In Hell", "Hell"));
            //Console.WriteLine(STFuncs.Func11("Josh Fosh", 4));
            //Console.WriteLine(STFuncs.Func12("Josh Fosh", 3));
            Console.WriteLine(STFuncs.Func13("Josh In Hell", "In"));

        }
        public static bool Func1(string str, char ch)
        {

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool Func2(string str1, string str2)
        {
            if (str1.Length == str2.Length)
            {
                return true;
            }
            return false;
        }
        public static bool Func3(string str1, string str2)
        {
            for (int i = 0; str1.Length == str2.Length && i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    return false;
                }
                if (str1.Length == str2.Length)
                {
                    return true;
                }
            }
            return true;
        }
        public static string Func4(string addressee, string yourName )
        {
            string letterbody = "";
            letterbody = Console.ReadLine();
            return($"Hello {addressee}\n\n{letterbody}\n\nBest Regards,\n{yourName}");
        }
        public static string Func5(string str)
        {
            string newStr = "";
            for (int i = str.Length - 1; i > -1; i--)
            {
                newStr += str[i];
            }
            return newStr;
        }
        public static char Func6_a(char capitalC)
        {
            int ch = 'a' - 'A';
            if(capitalC >= 'a' && capitalC <= 'z')
            {
                capitalC = (char)(capitalC-ch);
            }
            return capitalC;
        }
        public static string Func6_b(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
              newStr += STFuncs.Func6_a(str[i]);
            }
            return newStr;
        }
        public static int Func7(string str, char ch)
        {
            int x = 'a' - 'A';
            int countCH = 0;
            for (int i = 0; i < str.Length; i++)
            {
                    if ( ch == str[i] || ch+x == str[i] || ch-x == str[i])
                    countCH++;
            }
            return countCH;
        }
        public static int Func8(string str, char ch)
        {
            for(int i = 0; i<str.Length; i++)
            {
                if (str[i] == ch)
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool Func9(string str1, string str2)
        {
            int count = 0;
                for(int i = 0; i<str2.Length; i++)
                {
                    if (str1[i] == str2[i])
                        count++;
                }
            if(count == str2.Length)
            {
                return true;
            }
            return false;
        }
        public static bool Func10(string str1, string str2)
        {
            str1 = Func5(str1);
            str2 = Func5(str2);
            if (Func9(str1, str2))
            {
                return true;
            }
            return false;
            
        }
        public static string Func11(string str, int k)
        {
            string newStr = "";
            for(int i = 0; i <= k; i++)
            {
                if (k <= str.Length)
                {
                    newStr += str[i];
                }
            }
                return newStr;  
        }
        public static string Func12(string str, int k)
        {
            string newStr = "";
            for(int i = k; i < str.Length; i++)
            {
                if(k <= str.Length)
                {
                    newStr += str[i];
                }
            }
            return newStr;
        }
        public static bool Func13(string str1, string str2)
        {
            string bigger = "", smaller = "";
            if(str1.Length > str2.Length)
            {
                bigger = str1;
                smaller = str2;
            }
            else
            {
                bigger = str2;
                smaller = str1;
            }
            while(bigger.Length >= smaller.Length)
            {
                if (STFuncs.Func9(bigger, smaller))
                    return true;
                bigger = STFuncs.Func12(bigger, 1);
            }
            return false;
        }
      
    }
}
