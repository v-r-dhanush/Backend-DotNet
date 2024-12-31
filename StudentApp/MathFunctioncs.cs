using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentApp
{
    internal class MathFunctioncs
    {
        public void mathfun()
        {
            Console.WriteLine("enter the a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the d");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Output: " + Math.Min(a, b));
            Console.WriteLine("Output: " + Math.Max(a, b));
            Console.WriteLine("Output: " + Math.Floor(c));
            Console.WriteLine("Output: " + Math.Ceiling(c));
            Console.WriteLine("Output: " + Math.Round(c));
            Console.WriteLine("Output: " + Math.Abs(d));
            Console.WriteLine("Output: " + Math.Pow(a, b));
            Console.WriteLine("Output: " + Math.Sqrt(b));

        }

        public void arr()
        {
            Console.WriteLine("enter the input");
            int[] iarr = new int[6];



            for (int i = 0; i < 6; i++)
            {
                iarr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int minValue = iarr[0];
            int maxValue = iarr[0];

            foreach (int num in iarr)
            {
                minValue = Math.Min(minValue, num);
                maxValue = Math.Max(maxValue, num);
            }
            Console.WriteLine("Minimum Value: " + minValue);
            Console.WriteLine("Maximum Value: " + maxValue);

            Array.Sort(iarr);
            Console.WriteLine("without using math function smallest number in array is " + iarr[0]);
            Console.WriteLine("without using math function largest number in array is " + iarr[5]);

            
        }   
    }
}
