using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPro
{
    internal class Counter
    {
        public class Increment
        {
            public int counter = 1;
            public void doIncrement()
            {
                counter += 5;
                Console.WriteLine(counter);
            }
        }
    }
}
