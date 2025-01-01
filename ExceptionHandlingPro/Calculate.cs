using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPro
{
    internal class Calculate
    {
        public void Add(int a , int b)
        {
            int result = a + b;
            Console.WriteLine("Sum of " + a + " " + b + " is " +result);
        }
        public void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Minus of " + a + " " + b + " is " + result);
        }
    }
}
