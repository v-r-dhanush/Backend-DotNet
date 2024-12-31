using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    internal class company
    {
        private int cid;
        private string cname;

        public company (int id,string name)
        {
            this.cid = id;
            this.cname = name;
        }
        public void displayCompanyDetails()
        {
            Console.WriteLine("Company Registration Number:" + this.cid);
            Console.WriteLine("Company Name:" + this.cname);
        }
    }
}
