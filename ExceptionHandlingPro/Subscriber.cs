using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPro
{
    internal class Subscriber
    {
        public void dowork()
        {
            Publisher p = new Publisher();
            //p.myevent += delegate (int a, int b)
            //{
            //    int result = a + b;
            //    Console.WriteLine("Sum of " + a + " " + b + " is " + result);
            //};
            p.myevent += (a, b) => (a + b); //Lambda Expression
            p.increment();

        }
    }
}
