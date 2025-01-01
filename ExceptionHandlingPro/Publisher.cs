using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExceptionHandlingPro.Program;

namespace ExceptionHandlingPro
{
    
    internal class Publisher
    {
        public event calc myevent;

        public int x = 0, y = 0;
        public void increment()
        {
            x += 5;
            y += 5;
            int res = myevent(x, y);
            Console.WriteLine(res);
        }
    }
}
