using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class Traveler
    {
        private Passport passport;
        private bool hasPaid;
        public Traveler(Passport passport, bool hasPaid)
        {
            this.passport = passport;
            this.hasPaid = hasPaid;
        }

        public Traveler(Traveler traveler) : this(traveler.passport, traveler.hasPaid)
        {

        }
        public void Pay()
        {
            this.hasPaid = true;
        }

        public bool HasPaid()
        {
            return this.hasPaid;
        }

        public override string ToString()
        {
            return $"{this.passport.ToString()} \n HasPaid: {this.hasPaid}";
        }

        public bool CheckTravel(Date travelDate)
        {
            return hasPaid && passport.IsValid(travelDate);
        }

        public static int CanDriveCount(Traveler[] passangers)
        {
            Date d = new Date();
            int count = 0;
            for (int i = 0; i < passangers.Length; i++)
            {
                if (passangers[i].CheckTravel(d))
                    count++;
            }
            return count;
        }

        public static void UnitTest()
        {
            Passport p1 = new Passport("Po", 1, new Date(5, 2, 2028));
            Passport p2 = new Passport("So", 1, new Date(28, 11, 2022));
            Passport p3 = new Passport("Do", 1, new Date(17, 1, 2029));
            Passport p4 = new Passport("Do", 1, new Date(21, 7, 2027));
            Traveler t1 = new Traveler(p1, false);
            Traveler t2 = new Traveler(p2, true);
            Traveler t3 = new Traveler(p3, true);
            Traveler t4 = new Traveler(p4, false);
            Console.WriteLine(t1);
            Date travelDate = new Date(1, 10, 2026);
            Console.WriteLine(t1.CheckTravel(travelDate));
            t1.Pay();
            Console.WriteLine(t1.CheckTravel(travelDate));
            Traveler[] passangers = { t1, t2, t3, t4 };
            Console.WriteLine(Traveler.CanDriveCount(passangers));
        }
    }
}