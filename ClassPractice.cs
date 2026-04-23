using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class ClassPractice
    {
        public static void UnitTest()
        {
            NonstaticClasses student1; //student1 - מצביע 
            student1 = new NonstaticClasses("Josh", 82, 98, 87, 17, 100); // new - יוצר את העצם
            //מחלקה זה טיפוס נתונים עם פעולות
            //student1.name = "Josh";
            //student1.magen371 = 82;
            //student1.bagrut371 = 98;
            //student1.magen271 = 87;
            //student1.bagrut271 = 17;
            //student1.proj = 100;
            int g = student1.Calc371();

            //Console.WriteLine(g);
            //Console.WriteLine(student1.Calc271());
            //Console.WriteLine(student1.Has5());
            //Console.WriteLine(student1.Calc5());
            //Console.WriteLine(student1.FinalString());
            student1.SetBagrut271(71);
            Console.WriteLine(student1.GetBagrut271());
            Console.WriteLine(student1);
        }
    }
}
