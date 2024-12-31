using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentApp
{
    internal class Commonmethod
    {
        public string commonUI (string msg) 
        {
            Console.WriteLine(msg);
            string val = Console.ReadLine();
            return val;
        }
    }
}
