using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    public class NonstaticClasses
    {
        private string name;
        private int magen371;
        private int bagrut371;
        private int magen271;
        private int bagrut271;
        private int proj;

        public NonstaticClasses(string name, int magen371, int bagrut371, int magen271, int bagrut271, int proj)
        {
            this.name = name;
            this.magen371 = magen371;
            this.bagrut371 = bagrut371;
            this.magen271 = magen271;
            this.bagrut271 = bagrut271;
            this.proj = proj;
        }
        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public void SetBagrut271(int b2)
        {
            if (b2 >= 0 && b2 <= 100)
                this.bagrut271 = b2;
        }
        public int GetBagrut271()
        {
            return this.bagrut271;
        }
        public int GetMagen371() { return this.magen371; }
        public void SetBagrut371(int bagrut371)
        {
            if (bagrut371 >= 0 && bagrut371 <= 100)
                this.bagrut371 = bagrut371;
        }
        public int GetBagrut371() { return this.bagrut371; }
        public void SetMagen271(int magen271)
        {
            if (magen271 >= 0 && magen271 <= 100)
                this.magen271 = magen271;
        }
        public int GetMagen271() { return this.magen271; }
        public int GetProj() { return this.proj; }

        public int Calc371()
        {
            return (int)(this.magen371 * 0.3 + this.bagrut371 * 0.7 + 0.5);
        }
        public int Calc271()
        {
            return (int)(this.magen271 * 0.4 + this.bagrut271 * 0.6 + 0.5);
        }
        public bool Has5()
        {
            return this.bagrut271 >= 55;
        }

        public int Calc3()
        {
            return (int)(this.proj * 0.4 + this.Calc371() * 0.6 + 0.5 );
        }
        public int Calc5()
        {
            return (int)(this.Calc271() * 0.4 + this.Calc3() * 0.6 + 0.5);
        }
        //public string FinalString()
        //{
        //    string s = "";
        //    int final;
        //    if (Has5())
        //    {
        //        s = "You got 5 units in CS!\n";
        //        final = Calc5();
        //    }
        //    else
        //    {
        //        s = "You got 3 units in CS!\n";
        //        final = Calc3();
        //    }
        //    s += "Your final grade is: " + final;
        //    return s;
        //}
        public override string ToString()
        {
            string s = "";
            int final;
            if (this.Has5())
            {
                s = "You got 5 units in CS!\n";
                final = this.Calc5();
            }
            else
            {
                s = "You got 3 units in CS!\n";
                final = this.Calc3();
            }
            s += "Your final grade is: " + final;
            return s;
        }
        //this משתמשים תמיד שקוראים לתכונה או פעולה
        //לא לשכוח להשתמש ב-this כל מה שנוצר במחלקה ועושה לה שינויים
    }
}
