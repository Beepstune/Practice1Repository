using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class BasicMix
    {
        public static void UnitTest()
        {
            //Console.WriteLine(Basi.StringCaesar("ZazAf", -3));
            //Console.WriteLine(BasicMix.StringCaesar("ZazAf", 3));
            Console.WriteLine(BasicMix.StringBasicCypher("Hello Josh"));
            Console.WriteLine(BasicMix.StringBasicCypher("eHll ooJhs"));
        }

        public static char CaesarCipher(char ch, int num)
        {
            int dis = 'z' - 'a' + 1;
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                ch = (char)(ch + num);
                if (!((ch > 'a' && ch < 'z') || (ch > 'A' && ch < 'Z')))
                {
                    if (num > 0)
                        ch = (char)(ch - dis);
                    else
                        ch = (char)(ch + dis);
                }
            }
            return ch;
        }

        public static string StringCaesar(string str, int num)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                newStr += BasicMix.CaesarCipher(str[i], num);
            }
            return newStr;
        }


        public static string StringBasicCypher(string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i += 2)
            {
                if (i + 1 < str.Length)
                {
                    newStr += str[i + 1];
                }
                    newStr += str[i];
               
            }
            return newStr;
        }
    }
}