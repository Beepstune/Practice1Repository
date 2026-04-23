using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Passport
    {
        private string name;
        private int number;
        private Date expiryDate;
        public Passport(string name, int number, Date expiryDate)
        {
            this.name = name;
            this.number = number;
            this.expiryDate = expiryDate;
        }
        public Passport(Passport passport) : this(passport.name, passport.number, passport.expiryDate)
        {

        }

        public override string ToString()
        {
            return $"Name: {this.name} \n Pass. num: {this.number} \n Exp date: {this.expiryDate}";
        }

        public bool IsValid(Date dateChecked)
        {
            return dateChecked.CompareTo(expiryDate) <= 0;
        }

        public void SetExpiryDate(Date expiryDate) { this.expiryDate = expiryDate; }

        public static Passport[] ExpiredPassports(Passport[] passports)
        {
            Date today = new Date();
            int count = 0, j = 0;
            for (int i = 0; i < passports.Length; i++)
            {
                if (!passports[i].IsValid(today))
                    count++;
            }
            Passport[] ExpPassports = new Passport[count];
            for (int i = 0; i < passports.Length; i++)
            {
                if (!passports[i].IsValid(today))
                {
                    ExpPassports[j] = passports[i];
                    j++;
                }
            }
            return ExpPassports;
        }
        public static void UnitTest()
        {
            Passport pass = new Passport("Joe", 5, new Date(5, 3, 2027));
            Console.WriteLine(pass);
            Date d = new Date(1, 10, 2026);
            Console.WriteLine(pass.IsValid(d));
            Passport p1 = new Passport("Bo", 5, new Date(5, 3, 2029));
            Passport p2 = new Passport("Do", 5, new Date(1, 4, 2023));
            Passport p3 = new Passport("Vo", 5, new Date(21, 9, 2022));
            Passport[] passports = { p1, p2, p3 };
            Passport[] expPassports = Passport.ExpiredPassports(passports);
            Console.WriteLine("Expired passports:");
            for (int i = 0; i < expPassports.Length; i++)
            {
                Console.WriteLine(expPassports[i]);
            }
        }
    }
}