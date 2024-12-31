using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo

{
    internal class student
    {
        public int sid;
        public string sname;
        public static string collagename = "Dhanalakshmi";
        public string cname = "Engineering";
        public const int semester = 8;
        public readonly int NoOfMonthsInYear;

        public student(int sid, string sname)
        {
            this.sid = sid;
            this.sname = sname;
            NoOfMonthsInYear = 12;
        }
    }
}
